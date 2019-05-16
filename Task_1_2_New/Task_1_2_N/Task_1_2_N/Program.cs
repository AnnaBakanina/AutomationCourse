using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Square square = new Square();
            ConsoleHelper.GetResult(square, circle);
        }
    }
}
