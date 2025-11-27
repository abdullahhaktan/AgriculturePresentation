using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index
{
    public class _TeamComponentPartial:ViewComponent
    {
        private readonly ITeamService _teamService;

        public _TeamComponentPartial(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _teamService.TGetListAll();
            return View(values);
        }
    }
}
