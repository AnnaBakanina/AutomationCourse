using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_New
{
    public class ConsoleHelper
    {
        public static double GetValueToCreateObjectTypeOfCircle()
        {
            double inputedValue;
            bool inputedValueIsValid = false;
            
            while (!inputedValueIsValid)
            {
                Console.Write("Input radius: ");
                if (double.TryParse(Console.ReadLine(), out inputedValue))
                {
                    inputedValueIsValid = true;
                    return inputedValue;
                }
                else
                {
                    Console.WriteLine("Invalid value was entered.");
                }
            }
            return -1;
        }

        public static double GetValueToCreateObjectTypeOfSquare()
        {
            double inputedValue;
            bool inputedValueIsValid = false;
            
            while (!inputedValueIsValid)
            {
                Console.Write("Input square side: ");
                if (double.TryParse(Console.ReadLine(), out inputedValue))
                {
                    inputedValueIsValid = true;
                    return inputedValue;
                }
                else
                {
                    Console.WriteLine("Invalid value was entered.");
                }
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
            Console.WriteLine("Square area:  " + square.GetAreaOfSquare());
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
