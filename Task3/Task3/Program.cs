using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfElements = 0;

            Console.Write("Input start range value: ");
            int startRange = Convert.ToInt32(Console.ReadLine()); ;
            Console.Write("Input end range value: ");
            int endRange = Convert.ToInt32(Console.ReadLine()); ;
            int numberOfElements = endRange - startRange;
            int[] array = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++) 
            {
                array[i] = startRange;
                if (array[i] % 3 == 0 && array[i] % 5 != 0)
                {
                    sumOfElements += array[i];
                }
                startRange++;
            }
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine($"Sum ={sumOfElements}");
        }
    }
}
