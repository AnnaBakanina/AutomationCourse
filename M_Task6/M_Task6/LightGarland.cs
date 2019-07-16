using System;
using M_Task6.Enums;

namespace M_Task6
{
    public class LightGarland: Garland<Light>
    {
        public LightGarland(int numberOfLights):base(numberOfLights)
        {
            
        }

        public override void FillGarland(int numberOfLights)
        {
            for (int i = 0; i < numberOfLights; i++)
            {
                _newGarland.Add(new Light());
            }
        }
    }
}
