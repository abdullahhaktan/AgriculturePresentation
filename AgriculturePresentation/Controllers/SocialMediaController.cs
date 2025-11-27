using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IActionResult Index()
        {
            var values = _socialMediaService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia model)
        {
            SocialMediaValidator validator = new SocialMediaValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _socialMediaService.TInsert(model);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(model);
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.GetById(id);
            _socialMediaService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = _socialMediaService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia model)
        {
            SocialMediaValidator validator = new SocialMediaValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _socialMediaService.TUpdate(model);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(model);
        }

    }
}
