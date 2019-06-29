using System;
using System.Collections.Generic;

namespace M_Task6
{
    public abstract class Garland<T> where T: Light
    {
        protected List<T> _newGarland;

        protected void BuildGarland(int numberOfLights)
        {
            for (int i = 0; i < numberOfLights; i++)
            {
                _newGarland = new List<T>();
            }
        }
    }
}
