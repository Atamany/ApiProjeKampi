using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.ViewComponents.DashboardViewComponents
{
    public class _DashboardWidgetComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
