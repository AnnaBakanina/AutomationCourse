using System;

namespace M_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numberOfElements = 0;
            int sumOfElements = 0;
            string startRangeAliase = "start range";
            string endRangeAliase = "end range";

            int startRange = checkValidation(startRangeAliase);
            int endRange = checkValidation(endRangeAliase);

            if ((endRange - startRange) < 0 )
            {
                Console.WriteLine("Start range is less then end range.");

            } else
            {
                numberOfElements = endRange - startRange + 1;
            }

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
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum ={sumOfElements}");
        }

        private static int checkValidation(string typeValue)
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
