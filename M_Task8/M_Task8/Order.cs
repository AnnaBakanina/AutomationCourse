using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace M_Task8
{
    [Serializable]
    public class Order
    {
        [JsonProperty(PropertyName = "OrderID")]
        public int OrderID { get; set; }

        [JsonProperty(PropertyName = "NumberOfItems")]
        public int NumberOfItems { get; set; }

        [JsonProperty(PropertyName = "CustomerID")]
        public Customer CustomerID { get; set; }

        [JsonProperty(PropertyName = "ProductType")]
        public List<Product> ProductType { get; set; }

        public Order()
        {
            OrderID = 0;
            NumberOfItems = 0;
            CustomerID = new Customer();
            ProductType = null;
        }

        public Order(int orderID, int numberOfItems, /*string customerID*/ List<Product> productType)
        {
            this.OrderID = orderID;
            this.NumberOfItems = numberOfItems;
            this.CustomerID = new Customer();
            this.ProductType = productType;
        }
    }
}
