using System;
using System.Collections.Generic;
using M_Task6.Enums;

namespace M_Task6
{
    public class Light
    {
        public string LightStatus;

        public Light()
        {
            LightStatus = string.Empty;
        }

        public Light(string lightStatus)
        {
            LightStatus = lightStatus;
        }

        public virtual void PrintLight()
        {
            Console.WriteLine($"Buble is {LightStatus}");
        }
    }
}
