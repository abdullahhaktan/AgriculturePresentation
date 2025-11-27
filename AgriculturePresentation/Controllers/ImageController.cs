using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var values = _imageService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddImage(Image model)
        {
            ImageValidator validator = new ImageValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _imageService.TInsert(model);
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

        public IActionResult DeleteImage(int id)
        {
            var value = _imageService.GetById(id);
            _imageService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateImage(int id)
        {
            var value = _imageService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateImage(Image model)
        {
            ImageValidator validator = new ImageValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _imageService.TUpdate(model);
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
