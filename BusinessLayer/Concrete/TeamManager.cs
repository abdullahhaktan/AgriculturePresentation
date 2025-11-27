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
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public string LongestNamedPerson()
        {
            return _teamDal.LongestNamedPerson();
        }

        public void TDelete(Team t)
        {
            _teamDal.Delete(t);
        }

        public List<int> TeamCountThroughTheYears()
        {
           return _teamDal.TeamCountThroughTheYears();
        }

        public int TeamCountTitleStartsWithExpert()
        {
            return _teamDal.TeamCountTitleStartsWithExpert();
        }

        public int TeamCountWithInstagramAndTwitter()
        {
            return _teamDal.TeamCountWithInstagramAndTwitter();
        }

        public int TeamCountWithOnlyOneSocialMedia()
        {
            return _teamDal.TeamCountWithOnlyOneSocialMedia();
        }

        public int TeamCountWithoutAnySocialMedia()
        {
            return _teamDal.TeamCountWithoutAnySocialMedia();
        }

        public List<Team> TGetListAll()
        {
            return _teamDal.GetListAll();
        }

        public void TInsert(Team t)
        {
            _teamDal.Insert(t);
        }

        public void TUpdate(Team t)
        {
            _teamDal.Update(t);
        }
    }
}
