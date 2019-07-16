using System;
using System.Collections.Generic;
using System.IO;

namespace Task7_M
{
    public class ConsoleHelper
    {
        public static int numberOfItemsInDictionary = 0;
        public static Dictionary<int, Country> countries = new Dictionary<int, Country>();

        public static void ReadFromFile()
        {
            List<string> list = new List<string> { "!", ",", ".", "?", " ", "\'" };
            int index = 1;

            using (StreamReader stream = new StreamReader("text.txt", System.Text.Encoding.Default))
            {
                string countryName = string.Empty;
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    if (line == string.Empty)
                    {
                        continue;
                    }
                    list.ForEach(_ =>
                    {
                        string a = line.Trim().Replace(_, string.Empty);

                    });

                    countries.Add(index, new Country(countryName));
                    numberOfItemsInDictionary = index;
                    index++;
                }
            }
        }

        public static void Output()
        {
            foreach (KeyValuePair<int, Country> keyValue in countries)
            {
                if (keyValue.Value.IsTelenorSupported == false)
                    Console.WriteLine("" + keyValue.Value.Name);
            }
        }

        public static void AddNewCountryToTheDictionary()
        {
            numberOfItemsInDictionary += 1;
            countries.Add(numberOfItemsInDictionary, new Country("Ukraine"));
            using (StreamWriter sw = new StreamWriter("text.txt", false, System.Text.Encoding.Default))
            {
                foreach (KeyValuePair<int, Country> keyValue in countries)
                {
                    sw.WriteLine(keyValue.Value.Name);
                }
            }
        }


        public static void SetTelenorSupported()
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
