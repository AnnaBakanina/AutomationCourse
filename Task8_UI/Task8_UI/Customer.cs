using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_UI
{
    //Guid.NewGuid().ToString();
    public class Customer
    {
        public string CustomerID;
        public string Name;

        public Customer()
        {
            CustomerID = "";
            Name = "";
        }

        public Customer(string ID, string Name)
        {
            this.CustomerID = ID;
            this.Name = Name;
        }
    }
}
