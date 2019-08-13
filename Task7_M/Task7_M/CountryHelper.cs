using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task7_M
{
    public class CountryHelper
    {
        public static void AddNewCountryToTheDictionary(Dictionary<int, Country> dictionary, string countryName, int index)
        {
            index += 1;
            dictionary.Add(index, new Country(countryName));
            using (StreamWriter sw = new StreamWriter("text.txt", false, System.Text.Encoding.Default))
            {
                foreach (KeyValuePair<int, Country> keyValue in dictionary)
                {
                    sw.WriteLine(keyValue.Value.Name);
                }
            }
        }

        public static void SetTelenorSupported(Dictionary<int, Country> dictionary, List<string> telenorSupportedCountriesList)
        {
            foreach (KeyValuePair<int, Country> keyValue in dictionary)
            {
                foreach (string value in telenorSupportedCountriesList)
                {
                    if (keyValue.Value.Name == value)
                    {
                        keyValue.Value.IsTelenorSupported = true;
                    }
                }
            }
        }

        //public static void SetTelenorSupported(Dictionary<int, Country> allCountriesDictionary, List<string> telenorSupportedCountriesList)
        //{
        //    telenorSupportedCountriesList.ForEach(telenorSupportedCountryName =>
        //    {
        //        allCountriesDictionary
        //        .Where(_ => _.Value.Name.Equals(telenorSupportedCountryName))
        //        .ToList()
        //        .ForEach(c => c.Value.IsTelenorSupported = true);
        //    });
        //}
    }
}
