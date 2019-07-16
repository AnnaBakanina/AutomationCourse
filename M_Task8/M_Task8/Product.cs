using System;
using Newtonsoft.Json;

namespace M_Task8
{
    [Serializable]
    public class Product
    {
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Price")]
        public double Price { get; set; }

        public Product()
        {
            Name = string.Empty;
            Price = 0.0;
        }

        public Product( string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
