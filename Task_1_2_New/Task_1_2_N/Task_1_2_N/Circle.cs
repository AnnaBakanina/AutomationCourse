using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_N
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = ConsoleHelper.GetValueToCreateObject("radius of circle"); ;
        }

        public double GetAreaOfСircle()
        {
            return Math.Round(Math.PI, 2) * Math.Pow(Radius, 2);
        }
    }
}
