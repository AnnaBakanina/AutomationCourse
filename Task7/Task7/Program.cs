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
            const string path = "D:\\AQA\\NewFile.txt";
            Dictionary<int, Country> countries = new Dictionary<int, Country>();
            FileDialog();
            Output();

            void FileDialog()
            {
                int i = 1;
                using (StreamReader stream = new StreamReader(path))
                {
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        countries.Add(i,new Country(line));
                        i++;
                    }
                }
            }

            void Output()
            {
                foreach (KeyValuePair<int, Country> keyValue in countries)
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
                }
            }
        }
    }
}
