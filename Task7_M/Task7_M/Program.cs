using System;
using System.Collections.Generic;
using System.IO;

namespace Task7_M
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConsoleHelper.ReadFromFile();
            ConsoleHelper.Output();
            ConsoleHelper.AddNewCountryToTheDictionary();
            ConsoleHelper.SetTelenorSupported();
            ConsoleHelper.Output();
        }
    }
}
