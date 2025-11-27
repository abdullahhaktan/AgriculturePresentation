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
    public class NavbarSlideManager : INavbarSlideService
    {
        private readonly INavbarSlideDal _navbarSlideDal;

        public NavbarSlideManager(INavbarSlideDal navbarSlideDal)
        {
            _navbarSlideDal = navbarSlideDal;
        }

        public NavbarSlide GetById(int id)
        {
            return _navbarSlideDal.GetById(id);
        }

        public void TDelete(NavbarSlide t)
        {
            _navbarSlideDal.Delete(t);
        }

        public List<NavbarSlide> TGetListAll()
        {
            return _navbarSlideDal.GetListAll();
        }

        public void TInsert(NavbarSlide t)
        {
            _navbarSlideDal.Insert(t);
        }

        public void TUpdate(NavbarSlide t)
        {
            _navbarSlideDal.Update(t);
        }
    }
}
