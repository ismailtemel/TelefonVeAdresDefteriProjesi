using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonServices : IGenericServices<Person>
    {
        // Burdaki interface IGenericServices'den miras alıyor
    }
}
