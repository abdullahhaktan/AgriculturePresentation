using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Default_Index
{
    public class _LatestNewsComponentPartial:ViewComponent
    {
        private readonly IAnnouncementService _announcementService;

        public _LatestNewsComponentPartial(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _announcementService.TGetListAll().OrderByDescending(x => x.AnnouncementID).Take(3).ToList();
            return View(values);
        }
    }
}
