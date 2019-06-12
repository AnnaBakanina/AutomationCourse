using System;
using System.Collections.Generic;
using Task5_N.Enums;


namespace Task5_N
{
    public class ConsoleHelper
    {
        public static double time = 0.0;
        public const double hoursPerDay = 8.0;

        public static List<Task> AddListOfTasks()
        {
            List<Task> taskList = new List<Task>();
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
                taskList.Add(new Task(param1, param2, param3));

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

            return taskList;
        }

        public static void OutputList(List<Task> taskList)
        {
            for (int i = 0; i < taskList.Count; i++)
            {
               Console.WriteLine($"Task Name - {taskList[i].TaskName}, Priority - {taskList[i].TaskPriority}, Level - {taskList[i].TaskLevel};");
            }
        }

        public static double GetTime(int taskLevel, List<Task> taskList)
        {
            var value = taskLevel;
            Level eLevel = (Level)value;
            string stringValue = eLevel.ToString();
     

            return -1;
        }

    }
}
