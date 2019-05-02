using System;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine()); //радиус
            Console.Write("Введите сторону: ");
            double a = Convert.ToDouble(Console.ReadLine()); //сторона квадрата

            double GetAreaOfСircle()
            {
                return Pi*Math.Pow(r,2);
            }

            double GetAreaOfSquare()
            {
                return Math.Pow(a, 2);
            }

            bool SquareCanBePutInCircle()
            {
                bool val = true;
                if (r * 2 < a) val = true;
                else if (r * 2 >= a*Math.Sqrt(2)) val = false;
                return val;
            }

            Console.WriteLine($"Площадь круга:{GetAreaOfСircle()}");
            Console.WriteLine($"Площадь квадрата:{GetAreaOfSquare()}");
            if (SquareCanBePutInCircle() == true) Console.WriteLine("Круг можно вписать в квадрат");
            else Console.WriteLine("Квадрат можно вписать в круг");
        }
    }
}
