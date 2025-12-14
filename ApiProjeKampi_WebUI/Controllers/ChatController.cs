using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult SendChatWithAI()
        {
            return View();
        }
    }
}
