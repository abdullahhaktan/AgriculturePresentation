using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team model)
        {
            TeamValidator validator = new TeamValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _teamService.TInsert(model);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View(model);
        }

        public IActionResult DeleteTeam(int id)
        {
            var value = _teamService.GetById(id);
            _teamService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            var value = _teamService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTeam(Team model)
        {
            TeamValidator validator = new TeamValidator();
            var result = validator.Validate(model);

            if (result.IsValid)
            {
                _teamService.TUpdate(model);
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
