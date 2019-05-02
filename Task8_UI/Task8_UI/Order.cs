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
        public Guid CustomerID;
        public string Type; //тип товара
    }
}
