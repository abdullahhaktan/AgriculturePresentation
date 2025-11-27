using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public int ActiveAnnouncementCount()
        {
            var context = new AgricultureContext();
            var activeAnnouncementCount = context.Announcements.Count(a => a.Status == true);
            return activeAnnouncementCount;
        }

        public int ActiveAnnouncementCountTitleShorterThan20()
        {
            var context = new AgricultureContext();
            var count = context.Announcements.Count(a => a.Status == true && a.Title.Length < 20);
            return count;
        }

        public void AnnouncementStatusChangeToFalse(int id)
        {
            using var context = new AgricultureContext();
            var announcement = context.Announcements.Find(id);
            announcement.Status = false;
            context.Update(announcement);
            context.SaveChanges();
        }

        public void AnnouncementStatusChangeToTrue(int id)
        {
            using var context = new AgricultureContext();
            var announcement = context.Announcements.Find(id);
            announcement.Status = true;
            context.Update(announcement);
            context.SaveChanges();
        }

        public List<int> MonthlyAnnouncement()
        {
            var currentYear = DateTime.Now.Year;

            var monthlyCounts = new List<int>();

            for(int month = 1;month <=12; month++)
            {
                using var context = new AgricultureContext();
                var count = context.Announcements.Count(a => a.Date.Year == currentYear && a.Date.Month == month);
                monthlyCounts.Add(count);
            }

            return monthlyCounts;
        }

        public int Last3DaysAnnouncementCountAvg()
        {
            var context = new AgricultureContext();
            var threeDaysAgo = DateTime.Now.AddDays(-3);
            var announcementCount = context.Announcements.Count(a => a.Date >= threeDaysAgo);
            var average = announcementCount / 3;
            return average;
        }

        public string LongestTitleAnnouncementTitle()
        {
            using var context = new AgricultureContext();
            var announcement = context.Announcements.OrderByDescending(a => a.Title.Length).FirstOrDefault();
            return announcement.Title;
        }

        public DateTime OldestAnnouncementDate()
        {
            using var context = new AgricultureContext();
            var announcementDate = context.Announcements.OrderBy(context => context.Date).FirstOrDefault();
            return announcementDate.Date;
        }

        public int PassiveAnnouncementCount()
        {
            using var context = new AgricultureContext();
            var passiveAnnouncementCount = context.Announcements.Count(a => a.Status == false);
            return passiveAnnouncementCount;
        }

        public int ThisMonthAnnouncementCount()
        {
            using var context = new AgricultureContext();
            var currentMonth = DateTime.Now.Month;
            var announcementCount = context.Announcements.Count(a => a.Date.Month == currentMonth);
            return announcementCount;
        }

        public int TotalAnnouncementCount()
        {
            using var context = new AgricultureContext();
            var announcementCount = context.Announcements.Count();
            return announcementCount;
        }
    }
}
