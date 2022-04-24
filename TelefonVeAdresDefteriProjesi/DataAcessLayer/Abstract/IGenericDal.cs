using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        // Burada kullandığımız T kullanacağımız Entity' karşılık gelir. 
        // Where T : class'ı ise 1 classa ait tüm değerleri kullanmak için kullandık. 
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetById(int id);
    }
}
