using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> mealCollection = new Dictionary<string, List<string>>();
            string commands = Console.ReadLine();
            int countOfUnlikedMeals = 0;

            while (commands != "Stop")
            {
                string[] commandArgs = commands.Split("-");
                string mainCommand = commandArgs[0];
                

                if (mainCommand == "Like")
                {
                    string guest = commandArgs[1];
                    string meal = commandArgs[2];

                    if (!mealCollection.ContainsKey(guest))
                    {
                        mealCollection[guest] = new List<string>();
                    }
                    if (!mealCollection[guest].Contains(meal))
                    {
                        mealCollection[guest].Add(meal);
                    }
                }
                else if (mainCommand == "Unlike")
                {
                    string guest = commandArgs[1];
                    string meal = commandArgs[2];

                    if (!mealCollection.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!mealCollection[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else if (mealCollection[guest].Contains(meal))
                    {
                        mealCollection[guest].Remove(meal);
                        countOfUnlikedMeals++;
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                    }
                }

                commands = Console.ReadLine();
            }

            foreach (var guest in mealCollection.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.Write($"{guest.Key}: ");
                Console.WriteLine(String.Join(", ",guest.Value));
                
            }

            Console.WriteLine($"Unliked meals: {countOfUnlikedMeals}");
        }
    }
}
