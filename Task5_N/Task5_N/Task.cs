using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_N
{
   public class Task
    {
        public string TaskName { get; set; }
        public int TaskPriority { get; set; }
        public int TaskLevel { get; set; }

        public Task()
        {
            TaskName = "";
            TaskPriority = 0;
            TaskLevel = 0;
        }

        public Task(string name, int priority, int level)
        {
            this.TaskName = name;
            this.TaskPriority = priority;
            this.TaskLevel = level;
        }
    }
}
