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
            const int n = 12;
            int startRange = 20;
            int endRange = 40;
            int sum = 0;
            int[] array = new int[n];
            for (int i = 0; i < n - 1; i++) 
            {
                Console.Write("Input value: ");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp >= startRange && temp <= endRange) array[i] = temp;
                else Console.WriteLine("Value out of the range!");
                if (array[i] % 3 == 0 && array[i] % 5 != 0) sum += array[i];
            }
            Console.WriteLine("Sum =" + sum);
        }
    }
}
