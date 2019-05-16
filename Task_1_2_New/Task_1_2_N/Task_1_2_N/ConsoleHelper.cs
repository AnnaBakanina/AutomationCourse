using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_N
{
    class ConsoleHelper
    {
        public static double GetValueToCreateObject(string typeValue)
        {
            double inputedValue;
            bool inputedValueIsValid = false;
            int tries = 3;
            while (!inputedValueIsValid)
            {
                if (tries == 0)
                {
                    Console.WriteLine("The number of tries is expired.");
                    inputedValue = 5;
                    break;
                }

                Console.Write($"Input {typeValue}: ");
                if (double.TryParse(Console.ReadLine(), out inputedValue))
                {
                    inputedValueIsValid = true;
                    return inputedValue;
                }
                else
                {
                    Console.WriteLine("Invalid value was entered.");
                }

                tries--;
            }
            return -1;
        }

        public static bool SquareCanBePutInCircle(double radius, double squareSide)
        {
            bool putSquareInCircle = true;
            if (radius * 2 < squareSide)
            {
                putSquareInCircle = true;
            }
            else if (radius * 2 >= squareSide * Math.Sqrt(2))
            {
                putSquareInCircle = false;
            }
            return putSquareInCircle;
        }

        public static void GetResult(Square square, Circle circle)
        {
            Console.WriteLine("Circle area: " + circle.GetAreaOfСircle());
            Console.WriteLine("Square area: " + square.GetAreaOfSquare());
            if (SquareCanBePutInCircle(circle.Radius, square.Side) == true)
            {
                Console.WriteLine("Circle can be put in square");
            }
            else
            {
                Console.WriteLine("Square can be put in circle");
            }
        }
    }
}
