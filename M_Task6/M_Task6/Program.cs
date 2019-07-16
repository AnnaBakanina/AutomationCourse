using System;

namespace M_Task6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LightGarland lightGarland = new LightGarland(6);
            Console.WriteLine("Plain garland:");
            lightGarland.PrintGarland();
            ColoredLightGarland coloredLightGarland = new ColoredLightGarland(6);
            Console.WriteLine();
            Console.WriteLine("Colored garland:");
            coloredLightGarland.PrintGarland(); //debug On status light color
        }
    }
}
