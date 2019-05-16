using System;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            Console.Write("Input radius: ");
            double Radius = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Input square side: ");
            double SquareSide = Convert.ToDouble(Console.ReadLine()); 

            double GetAreaOfСircle()
            {
                return Pi * Math.Pow(Radius, 2);
            }

            double GetAreaOfSquare()
            {
                return Math.Pow(SquareSide, 2);
            }

            //bool SquareCanBePutInCircle()
            //{
            //    bool PutSquareInCircle = true;
            //    if (Radius * 2 < SquareSide)
            //    {
            //        PutSquareInCircle = true;
            //    }
            //    else if (Radius * 2 >= SquareSide * Math.Sqrt(2))
            //    {
            //        PutSquareInCircle = false;
            //    }
            //    return PutSquareInCircle;
            //}

            //Console.WriteLine("Square area: " + GetAreaOfСircle());
            //Console.WriteLine("Circle area:  " + GetAreaOfSquare());
            //if (SquareCanBePutInCircle() == true)
            //{
            //    Console.WriteLine("Circle can be put in square");
            //}
            //else
            //{
            //    Console.WriteLine("Square can be put in circle");
            //}
        }
    }
}
