using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class ColoredLight : Light
    {
        public int LightColor;
        
        public ColoredLight():base()
        {
            LightColor = 0;
        }

        public ColoredLight(int lightStatus, int lightColor):base(lightStatus)
        {

        }

        public override void BuildGarland(int numberOfLights)
        {

        }
    }
}
