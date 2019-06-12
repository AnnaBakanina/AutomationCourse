using System;
using System.Collections.Generic;
using Task6.Enums;

namespace Task6
{
    class Light : Garland
    {
        public DateTime CurrentMinutes;
        public int LightStatus;

        public Light()
        {
            LightStatus = 0;
        }

        public Light(int lightStatus)
        {
            DateTime minutes = DateTime.Now;
            if (Convert.ToDouble(minutes) % 2 == 0) 
            {
                this.LightStatus = (int)LightBulbStatus.Status.On;
            }
            else
            {
                this.LightStatus = (int)LightBulbStatus.Status.Off;
            }
        }

        public override void BuildGarland(int numberOfLights)
        {
            List<Light> newGarland = new List<Light>();

        }
    }
}
