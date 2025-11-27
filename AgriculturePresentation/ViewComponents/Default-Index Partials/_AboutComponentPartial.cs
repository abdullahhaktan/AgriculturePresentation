using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetListAll();
            return View(values);
        }
    }
}
