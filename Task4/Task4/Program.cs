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
            Console.Write("Введите слово: ");
            string str = Convert.ToString(Console.ReadLine());
            char[] strRev = str.ToCharArray();
            Array.Reverse(strRev);
            string conv_str = new string(strRev);
            if (str == conv_str) Console.WriteLine($"Слово \"{str}\" - палендром");
            else Console.WriteLine($"Слово \"{str}\" - не палендром");
        }
    }
}
