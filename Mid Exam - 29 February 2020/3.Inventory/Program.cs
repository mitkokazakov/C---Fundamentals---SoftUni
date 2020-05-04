using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string commands = Console.ReadLine();

            while (commands != "Craft!")
            {
                string[] commandArg = commands.Split(" - ");
                string mainCommand = commandArg[0];

                if (mainCommand == "Collect")
                {
                    string item = commandArg[1];

                    if (!journal.Contains(item))
                    {
                        journal.Add(item);
                    }
                }
                else if (mainCommand == "Drop")
                {
                    string item = commandArg[1];

                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                }
                else if (mainCommand == "Combine Items")
                {
                    string[] items = commandArg[1].Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];

                    if (journal.Contains(oldItem))
                    {
                        int indexToAdd = journal.IndexOf(oldItem);

                        if (indexToAdd == journal.Count-1)
                        {
                            journal.Add(newItem);
                        }
                        else
                        {
                            journal.Insert(indexToAdd+1, newItem);
                        }
                    }
                }
                else if (mainCommand == "Renew")
                {
                    string item = commandArg[1];

                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                        journal.Add(item);
                    }
                }


                commands = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", journal));
        }
    }
}
