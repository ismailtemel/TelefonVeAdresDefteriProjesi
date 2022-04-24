using DataAcessLayer.Abstract;
using DataAcessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntityFramework
{
    public class EfAddressAndPhoneRepository : GenericRepository<AddressAndPhone>, IAddressAndPhoneDal
    {
        // Bu classımız hem GenericRepository içinde yer alan metodları alacak hem de IAddressAndPhoneDal'ı alacak.
        // IAddressAndPhoneDal'ı BussinessLayer'daki constructor metodda kullandık.
    }
}
