using System;
using System.Collections.Generic;
using System.IO;

namespace Task7_M
{
    public class ConsoleHelper
    {
        public static List<Country> ReadFromFile()
        {
            List<string> Symbolslist = new List<string> { "!", ",", ".", "?", " ", "\'" };
            List<Country> CountriesNamesList = new List<Country>();

            using (StreamReader stream = new StreamReader("text.txt", System.Text.Encoding.Default))
            {
                string countryName = string.Empty;
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    if (line == string.Empty)
                    {
                        countryName = string.Empty;
                        continue;
                    }
                    Symbolslist.ForEach(_ =>
                    {
                        string cName = line.Trim().Replace(_,string.Empty);
                        if (cName!=line)
                        {
                            countryName = cName;
                            line = cName;
                        }
                        else
                        {
                            countryName = line;
                        }
                    });

                    CountriesNamesList.Add(new Country(countryName));
                }
                return CountriesNamesList;
            }
        }

        public static void Output(Dictionary<int, Country> dictionary)
        {
            foreach (KeyValuePair<int, Country> keyValue in dictionary)
            {
                if (!keyValue.Value.IsTelenorSupported)
                {
                    Console.WriteLine("" + keyValue.Value.Name);
                }
            }
        } 
    }
}
