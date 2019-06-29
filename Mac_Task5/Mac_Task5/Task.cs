using System;
namespace Mac_Task5
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
