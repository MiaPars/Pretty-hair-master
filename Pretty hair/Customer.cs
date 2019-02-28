using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretty_hair
{
    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZIP { get; set; }
        public string Town { get; set; }
        public string Telephone { get; set; }

        public Customer(string ID, string Name, string Address, string ZIP, string Town, string Telephone)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.ZIP = ZIP;
            this.Town = Town;
            this.Telephone = Telephone;
        }
    }
}
