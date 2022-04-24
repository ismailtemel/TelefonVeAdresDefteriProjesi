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
    public class AddressAndPhoneManager : IAddressAndPhoneServices
    {
        // Burada bir file türetiyoruz.
        // Ardından _addressAndPhoneDal'a bir atama yapmamamız gerekiyor.
        // Atama işlemi için constructor method kullanıyoruz.
        IAddressAndPhoneDal _addressAndPhoneDal;

        // Burada ilgili classımızı constructor haline dönüştürdük.
        // Parmatre olarak IAddressAndPhoneDal türünde bir değer aldı.
        // Ve bizim _addressAndPhoneDal 'a addressAndPhoneDal dan gelen değeri atadı.
        // Bu yapı sayesinde ilgili atamalarımızı sorunsuz bir şekilde kullanabileceğiz.
        public AddressAndPhoneManager(IAddressAndPhoneDal addressAndPhoneDal)
        {
            _addressAndPhoneDal = addressAndPhoneDal;
        }

        public AddressAndPhone GetById(int id)
        {
            return _addressAndPhoneDal.GetById(id);
        }

        public List<AddressAndPhone> GetList()
        {
            return _addressAndPhoneDal.GetListAll();
        }

        public void TAdd(AddressAndPhone t)
        {
            _addressAndPhoneDal.Insert(t);
        }

        public void TDelete(AddressAndPhone t)
        {
            _addressAndPhoneDal.Delete(t);
        }

        public void TUpdate(AddressAndPhone t)
        {
            _addressAndPhoneDal.Update(t);
        }
    }
}
