using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_N
{
    class Square
    {
        public double Side { get; set; }

        public Square()
        {
            Side = ConsoleHelper.GetValueToCreateObject("side of square");
        }

        public double GetAreaOfSquare()
        {
            return Math.Pow(Side, 2);
        }
    }
}
