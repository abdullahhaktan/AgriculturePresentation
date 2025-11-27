using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var values = _adminService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdmin(Admin model)
        {
            AdminValidator validator = new AdminValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _adminService.TInsert(model);
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

        public IActionResult DeleteAdmin(int id)
        {
            var value = _adminService.GetById(id);
            _adminService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
            var value = _adminService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAdmin(Admin model)
        {
            AdminValidator validator = new AdminValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _adminService.TUpdate(model);
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
