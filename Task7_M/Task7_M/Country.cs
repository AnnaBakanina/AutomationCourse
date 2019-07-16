using System;
namespace Task7_M
{
    public class Country
    {
        public string Name;
        public bool IsTelenorSupported;

        public Country()
        {
            Name = "";
            IsTelenorSupported = false;
        }

        public Country(string Name)
        {
            this.Name = Name;
        }
    }
}
