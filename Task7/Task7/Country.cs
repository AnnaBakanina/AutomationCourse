using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
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
