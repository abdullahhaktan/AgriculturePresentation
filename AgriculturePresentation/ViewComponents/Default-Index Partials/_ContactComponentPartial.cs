using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index
{
    public class _ContactComponentPartial:ViewComponent
    {
        private readonly IAddressService _addressService;

        public _ContactComponentPartial(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _addressService.TGetListAll().FirstOrDefault();
            return View(value);
        }
    }
}
