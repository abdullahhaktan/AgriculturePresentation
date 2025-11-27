using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult ContactDetail(int id)
        {
            var value = _contactService.GetById(id);
            return View(value);
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.GetById(id);
            _contactService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
