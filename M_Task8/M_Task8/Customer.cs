using System;
using Newtonsoft.Json;

namespace M_Task8
{
    [Serializable]
    public class Customer
    {
        [JsonProperty(PropertyName = "CustomerID")]
        public string CustomerID { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        public Customer()
        {
            CustomerID = "";
            Name = "";
        }

        public Customer(string iD, string name)
        {
            this.CustomerID = iD;
            this.Name = name;
        }
    }
}
