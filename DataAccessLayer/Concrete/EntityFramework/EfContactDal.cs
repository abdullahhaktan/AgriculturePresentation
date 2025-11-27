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
    public class EfContactDal(AgricultureContext _context) : GenericRepository<Contact>, IContactDal
    {
        public int ContactCount()
        {
            return _context.Contacts.Count();
        }

        public List<Contact> LastMessages()
        {
            var values = _context.Contacts.OrderByDescending(c => c.ContactId).Take(5).ToList();
            return values;
        }

        public int LastMonthContactCount()
        {
           return _context.Contacts.Count(c => c.Date.Year == DateTime.Now.Year && c.Date.Month == DateTime.Now.Month);
        }

        
    }
}
