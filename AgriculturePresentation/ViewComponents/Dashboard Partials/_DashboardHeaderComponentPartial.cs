using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Dashboard_Partials
{
    public class _DashboardHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
