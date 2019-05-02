using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_UI
{
    public class Order
    {
        public int OrderID;
        public int Num; //колличество едениц заказаного товара
        public string CustomerID;
        public string Type; //тип товара

        public Order()
        {
            OrderID = 0;
            Num = 0;
            CustomerID = string.Empty;
            Type = string.Empty;
        }

        public Order(int OrderID, int Num, string CustomerID, string Type)
        {
            this.OrderID = OrderID;
            this.Num = Num;
            this.CustomerID = CustomerID;
            this.Type = Type;
        }
    }
}
