using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    [AllowAnonymous]
    public class DefaultController(IContactService _contactService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }

        public IActionResult SendMessage(Contact contact)
        {
            contact.Date = DateTime.Now;
            ContactValidator contactValidator = new ContactValidator();
            var result = contactValidator.Validate(contact);

            if (!result.IsValid)
            {
                ViewBag.error = "Mesajınız gönderilirken hata oluştu. Lütfen bilgilerinizi kontrol ediniz. Alanlar boş olmamalı , mesaj minimum 20 karakter içermelidir ve tarih gelecekte bir tarih olamaz";
                return View("Index", contact);
            }
            TempData["success"] = "Mesaj gönderme başarılı";
            _contactService.TInsert(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}
