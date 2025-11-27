using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index
{
    public class _SocialMediaComponentPartial:ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _SocialMediaComponentPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGetListAll();
            return View(values);
        }
    }
}
