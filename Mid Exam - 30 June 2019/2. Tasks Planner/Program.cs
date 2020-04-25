using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] commandArg = commands.Split();
                string mainCommand = commandArg[0];

                if (mainCommand == "Complete")
                {
                    int index = int.Parse(commandArg[1]);
                    CompleteTheTask(tasks, index);
                }
                else if (mainCommand == "Change")
                {
                    int index = int.Parse(commandArg[1]);
                    ChangeTheHoursOfTask(tasks, commandArg, index);

                }
                else if (mainCommand == "Drop")
                {
                    int index = int.Parse(commandArg[1]);
                    DropTheTask(tasks, index);
                }
                else if (mainCommand == "Count")
                {
                    if (commandArg[1] == "Completed")
                    {
                        PrintCountOfComletedTasks(tasks);
                    }
                    else if (commandArg[1] == "Incomplete")
                    {
                        PrintCountOfIncompleteTasks(tasks);
                    }
                    else if (commandArg[1] == "Dropped")
                    {
                        PrintCountOfDroppedTasks(tasks);
                    }
                }
                commands = Console.ReadLine();
            }

            PrintIncompleteTasks(tasks);
        }

        private static void PrintIncompleteTasks(List<int> tasks)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] > 0)
                {
                    Console.Write(tasks[i] + " ");
                }
            }
        }

        private static void PrintCountOfDroppedTasks(List<int> tasks)
        {
            int counter = 0;

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] < 0)
                {
                    counter++;

                }
            }
            Console.WriteLine(counter);
        }

        private static void PrintCountOfIncompleteTasks(List<int> tasks)
        {
            int counter = 0;

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] > 0)
                {
                    counter++;

                }
            }
            Console.WriteLine(counter);
        }

        private static void PrintCountOfComletedTasks(List<int> tasks)
        {
            int counter = 0;

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] == 0)
                {
                    counter++;

                }
            }
            Console.WriteLine(counter);
        }

        private static void DropTheTask(List<int> tasks, int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index] = -1;
            }
        }

        private static void ChangeTheHoursOfTask(List<int> tasks, string[] commandArg, int index)
        {
            int time = int.Parse(commandArg[2]);

            if (index >= 0 && index < tasks.Count)
            {
                tasks[index] = time;
            }
        }

        private static void CompleteTheTask(List<int> tasks, int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index] = 0;
            }
        }
    }
}
