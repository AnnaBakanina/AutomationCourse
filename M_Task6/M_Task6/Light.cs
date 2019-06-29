using System;
using System.Collections.Generic;
using M_Task6.Enums;

namespace M_Task6
{
    public class Light
    {
        public DateTime CurrentMinutes;
        public int LightStatus;

        public Light()
        {
            var minutes = DateTime.Now.Minute;
            if (minutes % 2 == 0)
            {
                LightStatus = (int)LightBulbStatus.On;
            }
            else
            {
                LightStatus = (int)LightBulbStatus.Off;
            }
        }
    }
}
