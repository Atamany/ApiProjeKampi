using DotNetEnv;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.Controllers
{
    public class AIController : Controller
    {
        [HttpGet]
        public IActionResult CreateRecipeWithOpenAI()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRecipeWithOpenAI(string prompt)
        {
            Env.Load();
            var apiKey = Environment.GetEnvironmentVariable("OpenAIApiKey");
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
            var requestData = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "system", content = "Sen bir restorant için yemek önerilerini yapan bir yapay zeka aracısın. Amacımız kullanıcı tarafından girilen malzemelere göre yemek tarifi önerisinde bulunmak." },
                    new { role = "user", content = prompt }
                },
                temperature = 0.5,
            };
            var response = await client.PostAsJsonAsync("https://api.openai.com/v1/chat/completions", requestData);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<OpenAIResponse>();
                var content = result.choices[0].message.content;
                ViewBag.Recipe = content;
            }
            else {
                ViewBag.Recipe = "Yapay zeka ile iletişimde bir hata oluştu.";
            }
            return View();
        }
        public class OpenAIResponse
        {
            public List<Choice> choices { get; set; }
        }
        public class Choice
        {
            public Message message { get; set; }
        }
        public class Message
        {
            public string role { get; set; }
            public string content { get; set; }
        }
    }
}
