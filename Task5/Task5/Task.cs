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
        public int taskPriopity;
        public string taskLevel;

        public Task()
        {
            taskName = "";
            taskPriopity = 0;
            taskLevel = "";
        }

        public Task(string name, int priority, string level)
        {
            this.taskName = name;
            this.taskPriopity = priority;
            this.taskLevel = level;
        }
    }
}
