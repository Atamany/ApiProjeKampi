using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace ApiProjeKampi_WebUI.ViewComponents.HomePageViewComponents
{
    public class _HomePageStatisticsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomePageStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:7157/api/Statistics/YummyEventCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.EventCount = jsonData1;

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7157/api/Statistics/ReservationCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.ReservationCount = jsonData2;

            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7157/api/Statistics/CategoryCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData3;

            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:7157/api/Statistics/ProductCount");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData4;

            return View();
        }
    }
}
