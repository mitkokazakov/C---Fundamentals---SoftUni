using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> mailCollection = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] commandArgs = input.Split("->");
                string mainCommand = commandArgs[0];

                if (mainCommand == "Add")
                {
                    string username = commandArgs[1];

                    if (!mailCollection.ContainsKey(username))
                    {
                        mailCollection[username] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    
                }
                else if (mainCommand == "Send")
                {
                    string username = commandArgs[1];
                    string text = commandArgs[2];

                    if (mailCollection.ContainsKey(username))
                    {
                        mailCollection[username].Add(text);
                    }
                    else
                    {
                        mailCollection[username] = new List<string>();
                        mailCollection[username].Add(text);
                    }
                }
                else if (mainCommand == "Delete")
                {
                    string username = commandArgs[1];

                    if (mailCollection.ContainsKey(username))
                    {
                        mailCollection.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {mailCollection.Keys.Count}");

            foreach (var user in mailCollection.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var mail in user.Value)
                {
                    Console.WriteLine($" - {mail}");
                }
            }
        }
    }
}
