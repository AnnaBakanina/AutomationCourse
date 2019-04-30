using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//не закончено

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = 0.0, hoursPerDay = 8.0;
            Console.Write("Количество задач - ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество дней на выполнение задач - ");
            int num = Convert.ToInt32(Console.ReadLine());
            Task[] array = new Task[n];
            AddData();
            SortArrayByPriority();
            SortArrayByTaskLevel();
            Console.WriteLine("Количество времени необходимого для выполнения всех задач - " + time);
            TaskProcessing();

            //Methods
            void AddData()
            {
                for (int i = 0; i < n; i++) 
                {
                    Console.Write("Название: ");
                    string param1 = Convert.ToString(Console.ReadLine());
                    Console.Write("Приоритет: ");
                    string param2 = Convert.ToString(Console.ReadLine());
                    Console.Write("Сложность: ");
                    string param3 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    array[i] = new Task(param1, GetPriorityID(param2), param3);

                    time += LevelType(param3); 
                }
            }

            double LevelType(string taskLevel)
            {
                if (taskLevel == "Сложная") return 4;
                else if (taskLevel == "Средняя") return 2;
                else if (taskLevel == "Легкая") return 1;

                return -1;
            }

            int GetPriorityID(string taskPriority)
            {
                if (taskPriority == "Высокий") return 1;
                else if (taskPriority == "Средний") return 2;
                else if (taskPriority == "Низкий") return 3;

                return -1;
            }

            string GetPriorityByID(int priorityId)
            {
                if (priorityId == 1) return "Высокий";
                else if (priorityId == 2) return "Средний";
                else if (priorityId == 3) return "Низкий";

                return "";
            }

            void SortArrayByPriority()
            {
                for (int i = 0; i < n-1; i++)
                {
                    if (array[i].taskPriopity > array[i + 1].taskPriopity)
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
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i].taskPriopity == array[i + 1].taskPriopity)
                    {
                        if (LevelType(array[i].taskLevel) > LevelType(array[i + 1].taskLevel) || LevelType(array[i].taskLevel) < LevelType(array[i + 1].taskLevel))
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
                Console.Write("Введите приоритет задачи: ");
                string prior = Convert.ToString(Console.ReadLine());
                Console.Write("Введите количество дней на выполнение задач с заданным приоритетом: ");
                int days = Convert.ToInt32(Console.ReadLine());
                double t = 0.0;
                
                Console.WriteLine("Список задач с заданным приоритетом: ");
                for (int i = 0; i < n; i++)
                {
                    if (array[i].taskPriopity == GetPriorityID(prior))
                    {
                        Console.WriteLine("Название - " + array[i].taskName + ", Приоритет - " + GetPriorityByID(array[i].taskPriopity) + ", Сложность - " + array[i].taskLevel + ";");
                    }
                }
                
                Console.WriteLine("Список задач с заданным приоритетом, которые можно выполнить за заданное время: ");

                for (int i = 0; i < n; i++) 
                {
                    t += LevelType(array[i].taskLevel);
                    if (t <= hoursPerDay * days) 
                    {
                        Console.WriteLine("Название - " + array[i].taskName + ", Приоритет - " + GetPriorityByID(array[i].taskPriopity) + ", Сложность - " + array[i].taskLevel + ";");
                    }
                }
            }
        }
    }
}
