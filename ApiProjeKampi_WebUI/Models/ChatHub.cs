using DotNetEnv;
using Microsoft.AspNetCore.SignalR;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiProjeKampi_WebUI.Models
{
    public class ChatHub : Hub
    {
        private static readonly string apiKey = Environment.GetEnvironmentVariable("OpenAIApiKey");
        private const string modelGpt = "gpt-4o-mini";
        private readonly IHttpClientFactory _httpClientFactory;
        public ChatHub(IHttpClientFactory httpClientFactory)
        {
            Env.Load();
            var client = new HttpClient();
            _httpClientFactory = httpClientFactory;
        }
        private static readonly Dictionary<string, List<Dictionary<string, string>>> _history = new();
        public override Task OnConnectedAsync()
        {
            _history[Context.ConnectionId] =
                [
                new ()
            {
                    ["role"] = "system",
                    ["content"] = "You are a helpful assistant. Keep answes concise"
                }];
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            _history.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
        public async Task SendMessage(string userMessage)
        {
            await Clients.Caller.SendAsync("ReceiveUserEcho", userMessage);
            var history = _history[Context.ConnectionId];
            history.Add(new Dictionary<string, string>
            {
                ["role"] = "user",
                ["content"] = userMessage
            });
            await StreamOpenAI(history, Context.ConnectionAborted);
        }
        public async Task StreamOpenAI(List<Dictionary<string, string>> history, CancellationToken cancellationToken)
        {
            var client = _httpClientFactory.CreateClient("openai");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            var payload = new
            {
                model = modelGpt,
                messages = history,
                temperature = 0.2,
                stream = true
            };
            using var req = new HttpRequestMessage(HttpMethod.Post, "v1/chat/completions");
            req.Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            using var resp = await client.SendAsync(req, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            resp.EnsureSuccessStatusCode();
            using var stream = await resp.Content.ReadAsStreamAsync(cancellationToken);
            using var reader = new StreamReader(stream);
            var sb = new StringBuilder();
            while (!reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {
                var line = await reader.ReadLineAsync();
                if (string.IsNullOrWhiteSpace(line)) continue;
                if (!line.StartsWith("data: ")) continue;
                var data = line["data:".Length..].Trim();
                if (data == "[DONE]") break;
                try
                {
                    var chunk = JsonSerializer.Deserialize<ChatStreamChunk>(data);
                    var delta = chunk?.Choices?.FirstOrDefault()?.Delta?.Content;
                    if (!string.IsNullOrEmpty(delta))
                    {
                        sb.Append(delta);
                        await Clients.Caller.SendAsync("ReceiveToken", delta, cancellationToken);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing JSON: {ex.Message}");
                }
            }
            var full = sb.ToString();
            history.Add(new() { ["role"] = "assistant", ["content"] = full });
            await Clients.Caller.SendAsync("CompleteMessage", full, cancellationToken);
        }
        private sealed class ChatStreamChunk
        {
            [JsonPropertyName("choices")] public List<Choice>? Choices { get; set; }
        }
        private sealed class Choice
        {
            [JsonPropertyName("delta")] public Delta? Delta { get; set; }
            [JsonPropertyName("finish_reason")] public string? FinishReason { get; set; }
        }
        private sealed class Delta
        {
            [JsonPropertyName("content")] public string? Content { get; set; }
        }
    }
}
