using DotNetEnv;
using Microsoft.AspNetCore.SignalR;

namespace ApiProjeKampi_WebUI.Models
{
    public class ChatHub : Hub
    {
        private static readonly string apiKey = Environment.GetEnvironmentVariable("OpenAIApiKey");
        private const string model = "gpt-4o-mini";
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

        }
    }
}
