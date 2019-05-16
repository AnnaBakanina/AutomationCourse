using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_N
{
    class Circle
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    Console.WriteLine("Value need to be bigger then 0.");
                }
            }
        }

        public Circle()
        {
            Radius = 0.0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double GetAreaOfСircle()
        {
            return Math.Round(Math.PI, 2) * Math.Pow(Radius, 2);
        }
    }
}
