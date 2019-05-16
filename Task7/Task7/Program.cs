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
            int n = 0; 
            const string path = "D:\\AQA\\Tasks_AutoCourses\\Task7\\NewFile.txt";
            Dictionary<int, Country> countries = new Dictionary<int, Country>();
            FileDialog();
            SetTelenorSupported();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Available options:");
                Console.WriteLine("1. Add new country");
                Console.WriteLine("2. Show list of countries that are supported by Telenor");
                Console.WriteLine("3. Exit");

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
                int i = 1;
                using (StreamReader stream = new StreamReader(path))
                {
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        countries.Add(i,new Country(line));
                        n = i;
                        i++;
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
                n += 1;
                Console.Write("Input name of country: ");
                string cName = Convert.ToString(Console.ReadLine());
                countries.Add(n, new Country(cName));
            }

            void SetTelenorSupported()
            {
                foreach (KeyValuePair<int, Country> keyValue in countries)
                {
                    if (keyValue.Value.Name == "Denmark" || keyValue.Value.Name == "Hungary")
                        keyValue.Value.IsTelenorSupported = true;
                }
            }
        }
    }
}
