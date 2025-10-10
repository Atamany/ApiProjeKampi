using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebUI.ViewComponents
{
    public class _HeadDefaultComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
