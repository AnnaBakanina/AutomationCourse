using System;
using System.Collections.Generic;
using System.IO;

namespace Task7_M
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numberOfItemsInDictionary = 0;
            List<string> TelenorSupportedCounties = new List<string> { "Denmark", "Hungary" };
            Dictionary<int, Country> countries = new Dictionary<int, Country>();
            List<Country> CountriesList = ConsoleHelper.ReadFromFile();
            for (int i = 0; i < CountriesList.Count; i++) 
            {
               countries.Add(i, CountriesList[i]);
               numberOfItemsInDictionary = CountriesList.Count;
            }
            ConsoleHelper.Output(countries);
            CountryHelper.AddNewCountryToTheDictionary(countries, "Ukraine", numberOfItemsInDictionary);
            CountryHelper.SetTelenorSupported(countries, TelenorSupportedCounties);
            Console.WriteLine("List of countries that aer supported by Telenor: ");
            ConsoleHelper.Output(countries);
        }
    }
}

