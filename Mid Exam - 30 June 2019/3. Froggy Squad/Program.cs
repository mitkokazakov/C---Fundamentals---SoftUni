using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Froggy_Squad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogs = Console.ReadLine().Split().ToList();
            string commands = Console.ReadLine();

            while (true)
            {
                string[] commandArg = commands.Split();
                string mainCommand = commandArg[0];

                if (mainCommand == "Join")
                {
                    AddFrog(frogs, commandArg);
                }
                else if (mainCommand == "Jump")
                {
                    JumpFrog(frogs, commandArg);
                }
                else if (mainCommand == "Dive")
                {
                    DiveFrog(frogs, commandArg);
                }
                else if (mainCommand == "First")
                {
                    PrintFirstFrogs(frogs, commandArg);
                }
                else if (mainCommand == "Last")
                {
                    PrintLastFrogs(frogs, commandArg);
                }
                else if (commands == "Print Normal")
                {
                    Console.Write("Frogs: ");
                    Console.WriteLine(String.Join(" ", frogs));
                    break;
                }
                else if (commands == "Print Reversed")
                {
                    frogs.Reverse();
                    Console.Write("Frogs: ");
                    Console.WriteLine(String.Join(" ", frogs));
                    break;
                }
                commands = Console.ReadLine();
            }
        }

        private static void PrintLastFrogs(List<string> frogs, string[] commandArg)
        {
            int count = int.Parse(commandArg[1]);

            if (count > frogs.Count)
            {
                Console.WriteLine(String.Join(" ", frogs));
            }
            else
            {
                for (int i = frogs.Count - count; i < frogs.Count; i++)
                {
                    Console.Write(frogs[i] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintFirstFrogs(List<string> frogs, string[] commandArg)
        {
            int count = int.Parse(commandArg[1]);

            if (count > frogs.Count)
            {
                Console.WriteLine(String.Join(" ", frogs));
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(frogs[i] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void DiveFrog(List<string> frogs, string[] commandArg)
        {
            int index = int.Parse(commandArg[1]);

            if (index >= 0 && index < frogs.Count)
            {
                frogs.RemoveAt(index);
            }
        }

        private static void JumpFrog(List<string> frogs, string[] commandArg)
        {
            string name = commandArg[1];
            int index = int.Parse(commandArg[2]);

            if (index >= 0 && index < frogs.Count)
            {
                frogs.Insert(index, name);
            }
        }

        private static void AddFrog(List<string> frogs, string[] commandArg)
        {
            string name = commandArg[1];
            frogs.Add(name);
        }
    }
}
