using System;
using System.Collections.Generic;
using M_Task6.Enums;

namespace M_Task6
{
    public abstract class Garland<T>
        where T: Light
    {
        protected List<T> _newGarland;

        protected Garland(int numberOfLights)
        {
            _newGarland = new List<T>(numberOfLights);
            FillGarland(numberOfLights);
            
        }

        public void PrintGarland()
        {
            SetLightStatus();
            _newGarland.ForEach(light => { light.PrintLight(); });
        }

        public void SetLightStatus()
        {
            var minutes = DateTime.Now.Minute;
            for (int i = 0; i < _newGarland.Count; i++)
            {
                if (minutes % 2 == 0 && i % 2 == 0)
                {
                    _newGarland[i].LightStatus = Convert.ToString(LightBulbStatus.On);
                }
                else
                {
                    _newGarland[i].LightStatus = Convert.ToString(LightBulbStatus.Off);
                }
            }
        }

        public abstract void FillGarland(int numberOfLights);

    }
}
