using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItemsInDictionary = 0; 
            Dictionary<int, Country> countries = new Dictionary<int, Country>();
            FileDialog();
            Console.WriteLine("List of all countries: ");
            Output();
            SetTelenorSupported();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Available options:");
                Console.WriteLine("1. Add new country");
                Console.WriteLine("2. Show list of countries that are supported by Telenor");
                Console.WriteLine("3. Show current list of countries");
                Console.WriteLine("4. Exit");

                if (int.TryParse(Console.ReadLine(), out int menuOption))
                {
                    switch (menuOption)
                    {
                        case 1:
                            AddNewCountryToTheDictionary();
                            break;
                        case 2:
                            Output();
                            break;
                        case 3:
                            Output();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("The value is incorrect, please, try again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The value is incorrect, please, try again");
                }
            }
        
            void FileDialog()
            {
                char[] symbols = { '!', ',', '.', '?', ' ', '\'' };
                int index = 1;
                using (StreamReader stream = new StreamReader("NewFile.txt", System.Text.Encoding.Default))
                {
                    string countryName = string.Empty;
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        if (line == string.Empty)
                        {
                            continue;
                        }
                        char[] strArray = line.ToCharArray();
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
                                    countryName += strArray[i];
                                }
                            }
                        }
                        countries.Add(index, new Country(countryName));
                        countryName = string.Empty;
                        numberOfItemsInDictionary = index;
                        index++;
                    }
                }
            }

            void Output()
            {
                foreach (KeyValuePair<int, Country> keyValue in countries)
                {
                    if (keyValue.Value.IsTelenorSupported == false)
                        Console.WriteLine("" + keyValue.Value.Name);
                }
            }

            void AddNewCountryToTheDictionary()
            {
                numberOfItemsInDictionary += 1;
                Console.Write("Input name of country: ");
                string cName = Convert.ToString(Console.ReadLine());
                countries.Add(numberOfItemsInDictionary, new Country(cName));
                using (StreamWriter sw = new StreamWriter("NewFile.txt", false, System.Text.Encoding.Default))
                {
                    foreach (KeyValuePair<int, Country> keyValue in countries)
                    {
                        sw.WriteLine(keyValue.Value.Name);
                    }
                }
            }


            void SetTelenorSupported()
            { 
                foreach (KeyValuePair<int, Country> keyValue in countries)
                {
                    var isEqualDenmark = string.Equals(keyValue.Value.Name, "Denmark", StringComparison.OrdinalIgnoreCase);
                    var isEqualHungary = string.Equals(keyValue.Value.Name, "Hungary", StringComparison.OrdinalIgnoreCase);
                    if (isEqualHungary || isEqualDenmark)
                    {
                        keyValue.Value.IsTelenorSupported = true;
                    }
                }
            }
        }
    }
}
