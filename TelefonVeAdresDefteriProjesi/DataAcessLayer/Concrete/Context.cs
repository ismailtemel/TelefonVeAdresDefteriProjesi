using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Concrete
{
    public class Context : DbContext
    {
        // Burada sql bağlantımızı yaptık.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0P06I08\\SQLEXPRESS01;database=Defter; integrated security=true;");
        }
        // Burada entity katmanında oluşrutduğumuz tabloları sql'e geçirmek için DbContext sınıfından DbSet'i kullandık.
        // Bunu yaptıktan sonra Package Manager Console'da migration komutlarımızı yazarız.
        public DbSet<Person> Persons { get; set; }
        public DbSet<AddressAndPhone> AddressAndPhone { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
