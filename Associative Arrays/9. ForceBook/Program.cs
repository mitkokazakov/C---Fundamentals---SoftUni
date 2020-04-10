using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] joinUser = input.Split(" | ");
                    string side = joinUser[0].Trim();
                    string userName = joinUser[1].Trim();

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook[side] = new List<string>();
                    }
                    

                    if (!forceBook.Values.Any(x => x.Contains(userName)))
                    {
                        forceBook[side].Add(userName);
                    }
                }
                else if (input.Contains(" -> "))
                {
                    string[] switchUser = input.Split(" -> ");
                    string userName = switchUser[0].Trim();
                    string side = switchUser[1].Trim();
                    bool found = false;

                    foreach (var user in forceBook)
                    {
                        if (user.Value.Contains(userName))
                        {
                            user.Value.Remove(userName);
                            
                            //found = true;
                            //break;
                        }
                        
                    }

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook[side] = new List<string>();
                    }

                    forceBook[side].Add(userName);
                    Console.WriteLine($"{userName} joins the {side} side!");
                    //if (found == false)
                    //{
                    //    if (!forceBook.ContainsKey(side))
                    //    {
                    //        forceBook[side] = new List<string>();
                    //    }

                    //    forceBook[side].Add(userName);
                    //    Console.WriteLine($"{userName} joins the {side} side!");
                    //}


                }

                input = Console.ReadLine();
            }

            foreach (var side in forceBook.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
