using System;
using Newtonsoft.Json;

namespace M_Task8
{
    [Serializable]
    public class Shipment
    {
        [JsonProperty(PropertyName = "ShipmentID")]
        public string ShipmentID { get; set; }

        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "ShipmentOrderID")]
        public Order ShipmentOrderID { get; set; }

        [JsonProperty(PropertyName = "ShipmentStatus")]
        public bool ShipmentStatus { get; set; } //true-order sent, false not sent

        public Shipment()
        {
            ShipmentID = string.Empty;
            Address = string.Empty;
            ShipmentOrderID = new Order();
            ShipmentStatus = false;
        }

        public Shipment(string shipmentID, string address, /*Order orderID,*/ bool shipmentStatus)
        {
            this.ShipmentID = shipmentID;
            this.Address = address;
            this.ShipmentOrderID = new Order();
            this.ShipmentStatus = shipmentStatus;
        }
    }
}
