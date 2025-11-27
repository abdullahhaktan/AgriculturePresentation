using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index
{
    public class _BlogComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
