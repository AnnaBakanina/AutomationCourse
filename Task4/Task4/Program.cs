using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input phrase: ");
            string str = Console.ReadLine();
            char[] strArray = str.ToCharArray();
            char[] symbols = { '!', ',', '.', '?', ' ' };
            string strProcessed = string.Empty;
            //need to be finished

            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    for (int j = 0; j < symbols.Length; j++) 
            //    {
            //        if (strArray[i] == symbols[j])
            //        {
            //            break;
            //        }
            //    }
            //    strProcessed += strArray[i];
            //}
            string strReversed = string.Empty;
            for (int i = strArray.Length - 1; i >= 0; i--) 
            {
                strReversed += strArray[i];
            }

            if (strReversed.ToLower() == str.ToLower())
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
