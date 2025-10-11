using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryList()
        {
            return View();
        }
    }
}
