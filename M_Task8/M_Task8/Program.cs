using System;
using System.Linq;

namespace M_Task8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Shipment shipment = new Shipment("ShipmentID", "ShipmentAddress", true);
            FileHelper.SerealizationIntoJSONFile(shipment, "/Users/annabakanina/Documents/shipmentS.json");
        }
    }
}
