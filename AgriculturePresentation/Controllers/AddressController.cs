using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using BusinessLayer.ValidationRules.BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var value = _addressService.TGetListAll().FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(Address model)
        {
            AddressValidator validator = new AddressValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _addressService.TUpdate(model);
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
