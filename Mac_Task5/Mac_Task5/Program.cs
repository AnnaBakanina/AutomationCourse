using System;


namespace Mac_Task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConsoleHelper.AddListOfTasks();
            //ConsoleHelper.OutputList();
            ConsoleHelper.SortList();
            Console.WriteLine("Sorted tasks: ");
            ConsoleHelper.OutputList();
            ConsoleHelper.NumberOfDaysNeededToDoTaskWithSelectedPriority();
        }
    }
}
