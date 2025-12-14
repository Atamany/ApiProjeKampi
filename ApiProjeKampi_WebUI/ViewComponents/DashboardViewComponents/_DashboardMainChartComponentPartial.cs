using ApiProjeKampi_WebUI.DTOs.ReservationDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiProjeKampi_WebUI.ViewComponents.DashboardViewComponents
{
    public class _DashboardMainChartComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardMainChartComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7157/");

            var response = await client.GetAsync("api/Reservations/GetReservationStats");
            var json = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<List<ReservationChartDTO>>(json);

            return View(data);
        }
    }
}
