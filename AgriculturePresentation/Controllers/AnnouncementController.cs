using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values = _announcementService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcement model)
        {
            AnnouncementValidator validator = new AnnouncementValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _announcementService.TInsert(model);
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

        public IActionResult DeleteAnnouncement(int id)
        {
            var value = _announcementService.GetById(id);
            _announcementService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var value = _announcementService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(Announcement model)
        {
            AnnouncementValidator validator = new AnnouncementValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _announcementService.TUpdate(model);
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

        public IActionResult ChangeAnnouncementStatus(int id)
        {
            _announcementService.AnnouncementStatusChange(id);
            return RedirectToAction("Index");
        }

    }
}
