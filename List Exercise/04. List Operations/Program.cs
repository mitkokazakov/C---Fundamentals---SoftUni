using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();
                string mainCommand = commandArgs[0];

                if (mainCommand == "Add")
                {
                    AddNumber(numbers, commandArgs);
                }
                else if (mainCommand == "Insert")
                {
                    InsertNumber(numbers, commandArgs);

                }
                else if (mainCommand == "Remove")
                {
                    RemoveNumber(numbers, commandArgs);
                }
                else if (mainCommand == "Shift")
                {
                    string position = commandArgs[1];
                    int count = int.Parse(commandArgs[2]);

                    if (position == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (position == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ",numbers));
        }

        private static void ShiftRight(List<string> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

        private static void ShiftLeft(List<string> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        private static void RemoveNumber(List<string> numbers, string[] commandArgs)
        {
            int removeIndex = int.Parse(commandArgs[1]);
            if (removeIndex < 0 || removeIndex > numbers.Count-1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(removeIndex);
            }
            
        }

        private static void InsertNumber(List<string> numbers, string[] commandArgs)
        {
            string numberToInsert = commandArgs[1];
            int index = int.Parse(commandArgs[2]);
            if (index < 0 || index > numbers.Count-1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(index, numberToInsert);
            }
            
        }

        private static void AddNumber(List<string> numbers, string[] commandArgs)
        {
            string addElement = commandArgs[1];
            numbers.Add(addElement);
        }
    }
}
