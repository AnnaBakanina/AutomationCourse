using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace M_Task8
{
    [Serializable]
    public class Shipment
    {
        [NonSerialized]
        List<Product> products = new List<Product> { new Product("NewProduct", 23.758) };

        [JsonProperty(PropertyName = "ShipmentID")]
        public string ShipmentID { get; set; }

        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "ShipmentOrderID")]
        public Order ShipmentOrderID { get; set; }

        [JsonProperty(PropertyName = "ShipmentStatus")]
        public bool ShipmentStatus { get; set; } //true - order sent, false not sent

        public Shipment()
        {
            ShipmentID = string.Empty;
            Address = string.Empty;
            ShipmentOrderID = new Order();
            ShipmentStatus = false;
        }

        public Shipment(string shipmentID, string address, bool shipmentStatus)
        {
            this.ShipmentID = shipmentID;
            this.Address = address;
            this.ShipmentOrderID = new Order(1234, 3, products);
            this.ShipmentStatus = shipmentStatus;
        }
    }
}
