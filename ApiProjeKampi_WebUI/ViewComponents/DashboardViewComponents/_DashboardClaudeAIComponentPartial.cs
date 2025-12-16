using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.ViewComponents.DashboardViewComponents
{
    public class _DashboardClaudeAIComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
