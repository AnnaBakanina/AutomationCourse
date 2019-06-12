using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public abstract class Garland/*<T> where T: Bulb*/
    {
        public abstract void BuildGarland(int numberOfLights);
    }
}
