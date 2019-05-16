using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_N
{
    class Square
    {
        private double _side;
        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value > 0)
                {
                    _side = value;
                }
            }
        }

        public Square()
        {
            Side = 0.0;
        }

        public Square(double squareSide)
        {
            Side = squareSide;
        }

        public double GetAreaOfSquare()
        {
            return Math.Pow(Side, 2);
        }
    }
}
