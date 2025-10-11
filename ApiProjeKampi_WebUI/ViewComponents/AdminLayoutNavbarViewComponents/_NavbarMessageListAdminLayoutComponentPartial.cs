using ApiProjeKampi_WebUI.DTOs.ChefDTOs;
using ApiProjeKampi_WebUI.DTOs.MessageDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiProjeKampi_WebUI.ViewComponents.AdminLayoutNavbarViewComponents
{
    public class _NavbarMessageListAdminLayoutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _NavbarMessageListAdminLayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7157/api/Messages/MessageListByIsReadFalse");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMessageDTO>>(jsonData);
                ViewBag.MessageCount = values.Count;
                return View(values);
            }
            return View();
        }
    }
}
