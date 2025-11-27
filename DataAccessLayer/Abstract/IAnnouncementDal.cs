using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAnnouncementDal:IGenericDal<Announcement>
    {
        public void AnnouncementStatusChangeToFalse(int id);
        public void AnnouncementStatusChangeToTrue(int id);
        public int TotalAnnouncementCount();
        public int ActiveAnnouncementCount();
        public int ThisMonthAnnouncementCount();
        public string LongestTitleAnnouncementTitle();
        public int PassiveAnnouncementCount();
        public int Last3DaysAnnouncementCountAvg();
        public int ActiveAnnouncementCountTitleShorterThan20();
        public List<int> MonthlyAnnouncement();
        public DateTime OldestAnnouncementDate();
    }
}
