using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index.SilderComponents
{
    public class _SliderComponentPartial: ViewComponent
    {
        private readonly INavbarSlideService _navbarSildeService;

        public _SliderComponentPartial(INavbarSlideService navbarSildeService)
        {
            _navbarSildeService = navbarSildeService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _navbarSildeService.TGetListAll();
            return View(values);
        }
    }
}
