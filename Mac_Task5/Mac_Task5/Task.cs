using System;
namespace Mac_Task5
{
    public class Task
    {
        public string TaskName { get; set; }
        public int TaskPriority { get; set; }
        public int TaskLevel { get; set; }
        public int TaskSortParameter { get; set; }

        public Task()
        {
            TaskName = "";
            TaskPriority = 0;
            TaskLevel = 0;
            TaskSortParameter = 0;
        }

        public Task(string name, int priority, int level, int coef)
        {
            TaskName = name;
            TaskPriority = priority;
            TaskLevel = level;
            TaskSortParameter = coef;
        }
    }
}
