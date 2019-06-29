using System;

namespace M_Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string strProcessed = string.Empty;
            string strReversed = string.Empty;
            char[] symbols = { '!', ',', '.', '?', ' ', '\'' };
            Console.Write("Input phrase: ");
            string str = Console.ReadLine();
            char[] strArray = str.ToCharArray();

            for (int i = 0; i < strArray.Length; i++)
            {

                for (int j = 0; j < symbols.Length; j++)
                {
                    if (strArray[i] == symbols[j])
                    {
                        break;
                    }
                    if (j == symbols.Length - 1)
                    {
                        strProcessed += strArray[i];
                    }
                }
            }

            char[] strProcessedArray = strProcessed.ToCharArray();

            for (int i = strProcessedArray.Length - 1; i >= 0; i--)
            {
                strReversed += strProcessedArray[i];
            }

            if (strReversed.ToLower() == strProcessed.ToLower())
            {
                Console.WriteLine($"The word \"{str}\" is palendrom");
            }
            else
            {
                Console.WriteLine($"The word \"{str}\" is not palendrom");
            }
        }
    }
}
