using System;
using M_Task6.Enums;

namespace M_Task6
{
    public class ColoredLightGarland:Garland<ColoredLight>
    {
        public ColoredLightGarland(int numberOfLights):base(numberOfLights)
        {
            
        }

        public override void FillGarland(int numberOfLights)
        {
            int numberOfColors = Enum.GetValues(typeof(LightColor)).Length;
            for (int i = 0; i < numberOfLights; i++)
            {
                LightColor color = (LightColor)(i % numberOfColors);
                _newGarland.Add(new ColoredLight(color));
            }
        }
    }
}
