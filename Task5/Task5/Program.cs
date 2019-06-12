using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//enum в разные классы
// хэлпер
// валидация


//гирлянды
//абстрактный класс билд герлянда метод
//цветная наследуется от обычной
// в конструкторе реализация билд


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double hoursPerDay = 8.0;
            double time = 0.0; 
            Console.Write("Input number of tasks: ");
            int numberOfTasks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of days: ");
            int numberOfDays = Convert.ToInt32(Console.ReadLine());
            Task[] array = new Task[numberOfTasks];
            AddData();
            SortArrayByPriority();
            SortArrayByTaskLevel();
            Console.WriteLine($"Time needed to complete tasks: {time}");
            TaskProcessing();

            //Methods
            void AddData()
            {
                for (int i = 0; i < numberOfTasks; i++) 
                {
                    Console.Write("Input task name: ");
                    string param1 = Convert.ToString(Console.ReadLine());
                    Console.Write("Input task priority (1-High, 2-Middle, 3-Low): ");
                    int param2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input task level (1-Hard, 2-Middle, 3-Easy): ");
                    int param3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    array[i] = new Task(param1, param2, param3);

                    time += GetTime(param3); 
                }
            }

            double GetTime(int taskLevel)
            {
                if (taskLevel == 1) return 4;
                else if (taskLevel == 2) return 2;
                else if (taskLevel == 3) return 1;

                return -1;
            }

            void SortArrayByPriority()
            {
                for (int i = 0; i < numberOfTasks-1; i++)
                {
                    if (array[i].TaskPriority > array[i + 1].TaskPriority)
                    {
                        Task temp;
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }

            void SortArrayByTaskLevel()
            {
                for (int i = 0; i < numberOfTasks - 1; i++)
                {
                    if (array[i].TaskPriority == array[i + 1].TaskPriority)
                    {
                        if (GetTime(array[i].TaskLevel) > GetTime(array[i + 1].TaskLevel) || GetTime(array[i].TaskLevel) < GetTime(array[i + 1].TaskLevel))
                        {
                            Task temp;
                            temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                        }
                    }
                }
            }

            void TaskProcessing()
            {
                Console.Write("Input task priority (1-High, 2-Middle, 3-Low): ");
                int prior = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number of days that needed to do tasks: ");
                int days = Convert.ToInt32(Console.ReadLine());
                double t = 0.0;
                
                Console.WriteLine("List of tasks with needed priority: ");
                for (int i = 0; i < numberOfTasks; i++)
                {
                    if (array[i].TaskPriority == prior)
                    {
                        Console.WriteLine($"Task Name - {array[i].TaskName}, Priority - {array[i].TaskPriority}, Level - {array[i].TaskLevel};");
                    }
                }
                
                Console.WriteLine("List of tasks that can be done during entered number of days: ");
                for (int i = 0; i < numberOfTasks; i++) 
                {
                    t += GetTime(array[i].TaskLevel);
                    if (t <= hoursPerDay * days) 
                    {
                        var value = array[i].TaskPriority;
                        Enums.Priority enumDisplayStatus = (Enums.Priority)value;
                        string stringValue = enumDisplayStatus.ToString();

                        Console.WriteLine($"Task Name - {array[i].TaskName}, Priority - {array[i].TaskPriority}, Level - {array[i].TaskLevel};");
                    }
                }
            }
        }
    }
}
