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
    public class EfImageDal(AgricultureContext _context) : GenericRepository<Image>, IImageDal
    {
        public int TotalImageCount()
        {
            return _context.Images.Count();
        }
    }
}
