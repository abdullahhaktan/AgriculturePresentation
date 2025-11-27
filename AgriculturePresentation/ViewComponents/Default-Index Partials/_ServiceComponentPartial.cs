using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index
{
    public class _ServiceComponentPartial: ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _ServiceComponentPartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetListAll();
            return View(values);
        }
    }
}
