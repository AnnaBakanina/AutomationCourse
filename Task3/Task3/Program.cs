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
            string startRangeAliase = "start range";
            string endRangeAliase = "end range";

            int startRange = checkValidation(startRangeAliase);
            int endRange = checkValidation(endRangeAliase);
            int numberOfElements = endRange - startRange + 1;
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
            Console.WriteLine();
            Console.WriteLine($"Sum ={sumOfElements}");

            int checkValidation(string typeValue)
            {
                int enteredValue;
                bool inputedValueIsValid = false;
                int tries = 3;
                while (!inputedValueIsValid)
                {
                    if (tries == 0)
                    {
                        Console.WriteLine("The number of tries is expired.");
                        break;
                    }

                    Console.Write($"Input {typeValue} value: ");
                    if (int.TryParse(Console.ReadLine(), out enteredValue) && enteredValue > 0)
                    {
                        inputedValueIsValid = true;
                        return enteredValue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value was entered.");
                    }
                    tries--;
                }
                return 0;
            }
        }
    }
}
