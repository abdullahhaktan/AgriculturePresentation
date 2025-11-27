using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public int ActiveAnnouncementCount()
        {
            return _announcementDal.ActiveAnnouncementCount();
        }

        public int ActiveAnnouncementCountTitleShorterThan20()
        {
            return _announcementDal.ActiveAnnouncementCountTitleShorterThan20();
        }

        public void AnnouncementStatusChange(int id)
        {
            var value = _announcementDal.GetById(id);
            if (value.Status)
            {
                value.Status = false;
            }
            else
            {
                value.Status = true;
            }
            _announcementDal.Update(value);
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public int Last3DaysAnnouncementCount()
        {
            return _announcementDal.Last3DaysAnnouncementCountAvg();
        }

        public string LongestTitleAnnouncementTitle()
        {
            return _announcementDal.LongestTitleAnnouncementTitle();
        }

        public List<int> MonthlyAnnouncement()
        {
            return _announcementDal.MonthlyAnnouncement();
        }

        public DateTime OldestAnnouncementDate()
        {
            return _announcementDal.OldestAnnouncementDate();
        }

        public int PassiveAnnouncementCount()
        {
            return _announcementDal.PassiveAnnouncementCount();
        }

        public void TDelete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public List<Announcement> TGetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public int ThisMonthAnnouncementCount()
        {
            return _announcementDal.ThisMonthAnnouncementCount();
        }

        public void TInsert(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public int TotalAnnouncementCount()
        {
           return _announcementDal.TotalAnnouncementCount();
        }

        public void TUpdate(Announcement t)
        {
            _announcementDal.Update(t);
        }
    }
}
