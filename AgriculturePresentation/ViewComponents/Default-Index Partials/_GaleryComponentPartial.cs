using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index
{
    public class _GaleryComponentPartial : ViewComponent
    {
        private readonly IImageService _imageService;

        public _GaleryComponentPartial(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _imageService.TGetListAll();
            return View(values);
        }
    }
}
