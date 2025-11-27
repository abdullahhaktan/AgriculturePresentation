using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITeamDal:IGenericDal<Team>
    {
        string LongestNamedPerson();
        int TeamCountWithOnlyOneSocialMedia();
        int TeamCountWithInstagramAndTwitter();
        int TeamCountTitleStartsWithExpert();
        int TeamCountWithoutAnySocialMedia();
        List<int> TeamCountThroughTheYears();
    }
}
