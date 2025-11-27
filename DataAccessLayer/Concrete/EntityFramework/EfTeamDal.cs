using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfTeamDal(AgricultureContext _context) : GenericRepository<Team>, ITeamDal
    {
        public string LongestNamedPerson()
        {
            var longestName = _context.Teams.OrderByDescending(t=>t.PersonName.Length).Select(t=>t.PersonName).FirstOrDefault();

            return longestName;
        }

        public List<int> TeamCountThroughTheYears()
        {
            List<int> countList = new List<int>();

            int startYear = 2010;

            int currentYear = DateTime.Now.Year;

            for (int year = startYear; year <= currentYear; year++)
            {
                var activeCount = _context.Teams
                    .Count(t =>
                        t.JoinedDate.Year <= year &&

                        (t.LeaveDate == null ||
                        t.LeaveDate.Value.Year > year)
                    );

                countList.Add(activeCount);
            }
            return countList;
        }

        public int TeamCountTitleStartsWithExpert()
        {
            var count = _context.Teams.Count(t => t.Title.StartsWith("Expert"));

            return count;
        }

        public int TeamCountWithInstagramAndTwitter()
        {
            var teamCount = _context.Teams.Count(t => !string.IsNullOrEmpty(t.InstagramUrl) && !string.IsNullOrEmpty(t.TwitterUrl));
            return teamCount;
        }

        public int TeamCountWithOnlyOneSocialMedia()
        {
            int count = 0;
            foreach(var item in _context.Teams)
            {
                int socialMediaCount = 0;
                if(!string.IsNullOrEmpty(item.FacebookUrl))
                    socialMediaCount++;
                if(!string.IsNullOrEmpty(item.InstagramUrl))
                    socialMediaCount++;
                if(!string.IsNullOrEmpty(item.TwitterUrl))
                    socialMediaCount++;
                if(socialMediaCount == 1)
                    count++;
            }

            return count;
        }

        public int TeamCountWithoutAnySocialMedia()
        {
            int count = 0;
            foreach (var item in _context.Teams)
            {
                int socialMediaCount = 0;
                if (!string.IsNullOrEmpty(item.FacebookUrl))
                    socialMediaCount++;
                if (!string.IsNullOrEmpty(item.InstagramUrl))
                    socialMediaCount++;
                if (!string.IsNullOrEmpty(item.TwitterUrl))
                    socialMediaCount++;
                if (socialMediaCount == 0)
                    count++;
            }

            return count;
        }
    }
}
