using System;
using System.Collections.Generic;
using System.Linq;

namespace Mac_Task5
{
    public class ConsoleHelper
    { 
        public const double hoursPerDay = 8.0;
        public static List<Task> taskList = new List<Task>();

        public static int GetTaskSortParameter(int priority, int level)
        {
            return Convert.ToInt32($"{priority}{level}");
        }

        public static List<Task> AddListOfTasks()
        {
            double timeForTasks = 0.0;
            int enteredValue;
            bool addOneMore = true;

            do
            {
                Console.Write("Input task name: ");
                string param1 = Convert.ToString(Console.ReadLine());
                Console.Write("Input task priority (1-High, 2-Middle, 3-Low): ");
                int param2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input task level (1-Hard, 2-Middle, 3-Easy): ");
                int param3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                taskList.Add(new Task(param1, param2, param3, GetTaskSortParameter(param2, param3)));

                timeForTasks += GetTime(param3);

                Console.Write("Add one more task (1-Yes, 2-No): ");
                if (int.TryParse(Console.ReadLine(), out enteredValue) && enteredValue == 1)
                {
                    addOneMore = true;
                }
                else
                {
                    addOneMore = false;
                }

            } while (addOneMore);

            Console.WriteLine($"Time needed for all tasks - {timeForTasks}");
            return taskList;
        }

        public static void OutputList(int index)
        {
            var value = taskList[index].TaskPriority;
            Enums.Priority enumDisplayStatus = (Enums.Priority)value;
            string stringValuePriority = enumDisplayStatus.ToString();

            var valueLevel = taskList[index].TaskLevel; 
            Enums.Level enumDisplayStatusLevel = (Enums.Level)valueLevel;
            string stringValueLevel = enumDisplayStatusLevel.ToString();

            Console.WriteLine($"Task Name - {taskList[index].TaskName}, Priority - {stringValuePriority}, Level - {stringValueLevel};");
        }

        public static void OutputList()
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                var value = taskList[i].TaskPriority;
                Enums.Priority enumDisplayStatus = (Enums.Priority)value;
                string stringValuePriority = enumDisplayStatus.ToString();

                var valueLevel = taskList[i].TaskLevel;
                Enums.Level enumDisplayStatusLevel = (Enums.Level)valueLevel;
                string stringValueLevel = enumDisplayStatusLevel.ToString();

                Console.WriteLine($"Task Name - {taskList[i].TaskName}, Priority - {stringValuePriority}, Level - {stringValueLevel};");
            }
        }

        public static int GetTime(int taskLevel)
        {
            switch (taskLevel)
            {
                case 1:
                {
                    return (int)Enums.Time.Hard;
                }
                case 2:
                {
                    return (int)Enums.Time.Middle;
                }
                case 3:
                {
                    return (int)Enums.Time.Easy;
                }
                default:
                    return -1;
            }

        }

        public static void SortList() 
        {
            List<Task> sortedTasks = taskList.OrderBy(x => x.TaskSortParameter).ToList();
            taskList = sortedTasks;
            
            //for (int i = 0; i < taskList.Count - 1; i++)
            //{
            //    if (taskList[i].TaskPriority > taskList[i + 1].TaskPriority)
            //    {
            //        Task temp;
            //        temp = taskList[i];
            //        taskList[i] = taskList[i + 1];
            //        taskList[i + 1] = temp;
            //    }
            //}

            //for (int i = 0; i < taskList.Count - 1; i++)
            //{
            //    if (taskList[i].TaskPriority == taskList[i + 1].TaskPriority)
            //    {
            //        if (taskList[i].TaskLevel > taskList[i + 1].TaskLevel || taskList[i].TaskLevel < taskList[i + 1].TaskLevel)
            //        {
            //            Task temp;
            //            temp = taskList[i];
            //            taskList[i] = taskList[i + 1];
            //            taskList[i + 1] = temp;
            //        }
            //    }
            //}
        }

        public static void NumberOfDaysNeededToDoTaskWithSelectedPriority() 
        {
            double time = 0.0;
            Console.Write("Number of days that needed to do tasks: ");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("List of tasks that can be done during entered number of days: ");
            for (int i = 0; i < taskList.Count; i++)
            {
                double enteredTime = hoursPerDay * days;
                if (time+ GetTime(taskList[i].TaskLevel)<=enteredTime)
                {
                    time += GetTime(taskList[i].TaskLevel);
                    OutputList(i);
                }
                else
                {
                    continue;
                }
            }
        }

    }
}

