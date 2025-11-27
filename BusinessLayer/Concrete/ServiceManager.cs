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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> TGetListAll()
        {
            return _serviceDal.GetListAll();
        }

        public void TInsert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public int TotalServiceCount()
        {
            return _serviceDal.TotalServiceCount();
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
