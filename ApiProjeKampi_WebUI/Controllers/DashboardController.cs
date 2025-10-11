using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
