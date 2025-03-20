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
    public class AnnouncemenetManager : IAnnouncemenetService
    {
        private readonly IAnnouncemenetDal _announcemenetDal;

        public AnnouncemenetManager(IAnnouncemenetDal announcemenetDal)
        {
            _announcemenetDal = announcemenetDal;
        }

        public void TAdd(Announcemenet t)
        {
            _announcemenetDal.Insert(t);
        }

        public void TDelete(Announcemenet t)
        {
            _announcemenetDal.Delete(t);
        }

        public Announcemenet TGetById(int id)
        {
            return _announcemenetDal.GetByID(id);
        }

        public List<Announcemenet> TGetList()
        {
            return _announcemenetDal.GetList();
        }

        public void TUpdate(Announcemenet t)
        {
            _announcemenetDal.Update(t);
        }
    }
}
