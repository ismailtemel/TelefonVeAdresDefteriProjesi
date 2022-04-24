using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PersonManager : IPersonServices
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public Person GetById(int id)
        {
            return _personDal.GetById(id);
        }

        public List<Person> GetList()
        {
           return _personDal.GetListAll();
        }

        public void TAdd(Person t)
        {
            _personDal.Insert(t);
        }

        public void TDelete(Person t)
        {
            _personDal.Delete(t);
        }

        public void TUpdate(Person t)
        {
            _personDal.Update(t);
        }
    }
}
