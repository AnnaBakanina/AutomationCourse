using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_New
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(ConsoleHelper.GetValueToCreateObjectTypeOfCircle());
            Square square = new Square(ConsoleHelper.GetValueToCreateObjectTypeOfSquare());
            ConsoleHelper.GetResult(square, circle);
        }
    }
}
