using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class DashboardController(IAnnouncementService _announcementService, IServiceService _serviceService, IImageService _imageService, IContactService _contactService,ITeamService _teamService) : Controller
    {
        public IActionResult Index()
        {

            #region kategori 1
            ViewBag.AnnouncementCount = _announcementService.TotalAnnouncementCount();
            ViewBag.ActiveAnnouncementCount = _announcementService.ActiveAnnouncementCount();
            ViewBag.ThisMonthAnnouncementCount = _announcementService.ThisMonthAnnouncementCount();
            ViewBag.ServiceCount = _serviceService.TotalServiceCount();
            ViewBag.ImageCount = _imageService.TotalImageCount();
            #endregion

            #region kategori 2
            ViewBag.LongestTitleAnnouncementTitle = _announcementService.LongestTitleAnnouncementTitle();
            ViewBag.PassiveAnnouncementCount = _announcementService.PassiveAnnouncementCount();
            ViewBag.Last3DaysAnnouncementCount = _contactService.last30MonthsContactCount();
            ViewBag.ActiveAnnouncementCountTitleShorterThan20 = _announcementService.ActiveAnnouncementCountTitleShorterThan20();
            ViewBag.OldestAnnouncementDate = _announcementService.OldestAnnouncementDate();
            #endregion

            #region kategori 3
            ViewBag.LongestNamedPerson = _teamService.LongestNamedPerson();
            ViewBag.CountOneSocial = _teamService.TeamCountWithOnlyOneSocialMedia();
            ViewBag.CountInstaAndTwitter = _teamService.TeamCountWithInstagramAndTwitter();
            ViewBag.CountTitleStartsWithExpert = _teamService.TeamCountTitleStartsWithExpert();
            ViewBag.CountNoSocialMedia = _teamService.TeamCountWithoutAnySocialMedia();
            #endregion

            #region Grafik1
            ViewBag.MonthlyAnnouncementCounts = _announcementService.MonthlyAnnouncement();
            #endregion

            #region Grafik2
            ViewBag.TeamCounts = _teamService.TeamCountThroughTheYears();
            ViewBag.StartYear = 2010;
            ViewBag.CurrentYear = DateTime.Now.Year;
            ViewBag.TeamCount = _teamService.TGetListAll().Count();

            #endregion

            ViewBag.Dashboard = true;

            return View();
        }
    }
}
