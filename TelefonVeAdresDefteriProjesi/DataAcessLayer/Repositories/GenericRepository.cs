using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            //Burada context sınıfından bir değer türettik ve silme komutlarını yazdık.
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            // Burada ise kayıtlarımızı id'ye göre çekme işlemi uyguladık.
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            // Yukarıda void kullanmamamızın sebebi burdaki metodun geriye bir değer döndürecek olması.
            // Burada da aynı şekilde context sınıfdan bir değer türettik.
            // Ardından kayıtları listelemek için Set metodunu kullandık.
            // Set metodundaki T'yi entitylerimizi çekmek amacıyla kullandık.
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            //Buradaki savechanges normal .Net'teki executenonquery'e karşılık gelir.
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
