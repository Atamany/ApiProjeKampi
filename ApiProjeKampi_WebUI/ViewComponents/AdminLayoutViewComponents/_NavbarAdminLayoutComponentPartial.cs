using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _NavbarAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
