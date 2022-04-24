using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AddressAndPhone
    {
        [Key]
        public int AddressAndPhoneID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}
