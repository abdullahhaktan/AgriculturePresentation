using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index.SilderComponents
{
    public class _SliderPopupComponentPartial:ViewComponent
    {
        private readonly INavbarSlideService _navbarSlideService;

        public _SliderPopupComponentPartial(INavbarSlideService navbarSlideService)
        {
            _navbarSlideService = navbarSlideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _navbarSlideService.TGetListAll();
            return View(values);
        }
    }
}
