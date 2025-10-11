using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
