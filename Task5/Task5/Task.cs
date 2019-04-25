using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Task
    {
        public string taskName;
        public string taskPriopity;
        public string taskLevel;

        public Task()
        {
            taskName = "";
            taskPriopity = "";
            taskLevel = "";
        }

        public Task(string name, string priority, string level)
        {
            this.taskName = name;
            this.taskPriopity = priority;
            this.taskLevel = level;
        }
    }
}
