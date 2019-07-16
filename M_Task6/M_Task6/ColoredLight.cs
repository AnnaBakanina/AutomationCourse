using System;
using M_Task6.Enums;

namespace M_Task6
{
    public class ColoredLight : Light
    {
        public LightColor LightColor;

        public ColoredLight()
        {
            LightColor = LightColor.Red;
        }

        public ColoredLight(LightColor lightColor)
        {
            LightColor = lightColor;
        }

        public override void PrintLight()
        {
            Enum.TryParse(LightColor.ToString(), out ConsoleColor color);
            Console.ForegroundColor = color;
            Console.WriteLine($"Buble is {LightStatus} and {LightColor}");
            Console.ResetColor();
        }
    }
}
