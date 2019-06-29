using System;

namespace M_Task6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            T lamp = new T();
            ColoredLight cLamp = new ColoredLight();
            lamp.BuildGarland(6);
            cLamp.BuildGarland(6);
        }
    }
}
