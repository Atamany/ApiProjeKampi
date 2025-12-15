using ApiProjeKampi_WebAPI.DTOs.ReservationDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace ApiProjeKampi_WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateReservationDTO createReservationDTO)
        {
            createReservationDTO.ReservationStatus = "Beklemede";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createReservationDTO);
            StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7157/api/Reservations/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction();
        }
    }
}
