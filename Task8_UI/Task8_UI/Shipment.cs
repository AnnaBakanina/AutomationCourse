using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_UI
{
    public class Shipment
    {
        public string ShipmentID;
        public string Address;
        public int? OrderID;
        public bool ShipmentStatus; //true-order sent, false not sent

        public Shipment()
        {
            ShipmentID = string.Empty;
            Address = string.Empty;
            OrderID = null;
            ShipmentStatus = false;
        }

        public Shipment(string ShipmentID, string Address, int? OrderID, bool ShipmentStatus)
        {
            this.ShipmentID = ShipmentID;
            this.Address = Address;
            this.OrderID = OrderID;
            this.ShipmentStatus = ShipmentStatus;
        }
    }
}
