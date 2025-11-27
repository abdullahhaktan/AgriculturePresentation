using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfServiceDal(AgricultureContext _context) : GenericRepository<Service>, IServiceDal
    {
        public int TotalServiceCount()
        {
            return _context.Services.Count();
        }
    }
}
