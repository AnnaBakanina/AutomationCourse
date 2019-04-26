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
            double time = 0.0, hoursPerDay = 12.0;
            Console.Write("Количество задач - ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество дней на выполнение задач - ");
            int num = Convert.ToInt32(Console.ReadLine());
            Task[] array = new Task[n];
            AddData();
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
                    array[i] = new Task(param1, param2, param3);

                    time += LevelType(param3); 
                }
            }

            double LevelType(string param)
            {
                if (param == "Сложная") return 4;
                else if (param == "Средняя") return 2;
                else if (param == "Легкая") return 1;

                return -1;
            }

            void TaskProcessing()
            {
                int m = 0;
                Console.Write("Введите приоритет задачи: ");
                string prior = Convert.ToString(Console.ReadLine());
                Console.Write("Введите количество дней на выполнение задач с заданным приоритетом: ");
                int days = Convert.ToInt32(Console.ReadLine());
                double t = 0.0;
                
                Console.WriteLine("Список задач с заданным приоритетом: ");
                for (int i = 0; i < n; i++)
                {
                    if (array[i].taskPriopity == prior)
                    {
                        Console.WriteLine("Название - " + array[i].taskName + ", Приоритет - " + array[i].taskPriopity + ", Сложность - " + array[i].taskLevel + ";");
                    }

                }

                //какие задачи возможно сделать за N дней с учетом приоритета (N ввести с клавиатуры)
                Console.WriteLine("Список задач с заданным приоритетом, которые можно выполнить за заданное время: ");
                for (int i = 0; i < n; i++) 
                {
                    Console.Write("Название - " + array[i].taskName + ", Приоритет - " + array[i].taskPriopity + ", Сложность - " + array[i].taskLevel + ";");
                }
            }
        }
    }
}
