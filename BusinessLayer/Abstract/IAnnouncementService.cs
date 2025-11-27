using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnnouncementService:IGenericService<Announcement>
    {
        public void AnnouncementStatusChange(int id);
        public int TotalAnnouncementCount();
        public int ActiveAnnouncementCount();
        public int ThisMonthAnnouncementCount();
        public string LongestTitleAnnouncementTitle();
        public int PassiveAnnouncementCount();
        public int Last3DaysAnnouncementCount();
        public int ActiveAnnouncementCountTitleShorterThan20();
        public List<int> MonthlyAnnouncement();
        public DateTime OldestAnnouncementDate();
    }
}
