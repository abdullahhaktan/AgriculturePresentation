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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public int ContactCount()
        {
            return _contactDal.ContactCount();
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public int last30MonthsContactCount()
        {
            return _contactDal.LastMonthContactCount();
        }

        public List<Contact> LastMessages()
        {
            return _contactDal.LastMessages();
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
