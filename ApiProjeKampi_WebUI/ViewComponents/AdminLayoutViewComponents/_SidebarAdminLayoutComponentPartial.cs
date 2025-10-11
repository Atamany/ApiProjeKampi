using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _SidebarAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
