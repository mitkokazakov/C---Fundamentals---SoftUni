using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            ChangeList(numbers);

            Console.WriteLine(String.Join(" ", numbers));
        }

        private static void ChangeList(List<int> numbers)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArray = command.Split();

                if (commandArray[0] == "Delete")
                {
                    int currentElement = int.Parse(commandArray[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == currentElement)
                        {
                            numbers.Remove(currentElement);
                        }
                    }
                }
                else if (commandArray[0] == "Insert")
                {
                    int currentItem = int.Parse(commandArray[1]);
                    int currentIndex = int.Parse(commandArray[2]);

                    numbers.Insert(currentIndex, currentItem);
                }




                command = Console.ReadLine();
            }
        }
    }
}
