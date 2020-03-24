using System;
using System.Linq;
using System.Collections.Generic;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string commands = Console.ReadLine();
            List<Followers> listOfFollowers = new List<Followers>();

            while (commands != "Log out")
            {
                string[] commandArgs = commands.Split(": ");
                string mainCommand = commandArgs[0];
                string username = commandArgs[1];

                Followers followers = new Followers(username);
                Followers existUsername = listOfFollowers.Find(x => x.Username == username);

                if (mainCommand == "New follower")
                {
                    if (existUsername == null)
                    {
                        listOfFollowers.Add(followers);
                    }
                }
                else if (mainCommand == "Like")
                {
                    int count = int.Parse(commandArgs[2]);

                    if (existUsername == null)
                    {
                        followers.IncreaseLikes(username,count);
                        listOfFollowers.Add(followers);
                    }
                    else
                    {
                        existUsername.IncreaseLikes(username, count);
                    }
                }
                else if (mainCommand == "Comment")
                {
                    if (existUsername == null)
                    {

                        followers.IncreasaeComments(username);
                        listOfFollowers.Add(followers);
                    }
                    else
                    {
                        existUsername.IncreasaeComments(username);
                    }
                }
                else if (mainCommand == "Blocked")
                {
                    if (existUsername == null)
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        listOfFollowers.Remove(existUsername);
                    }
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine($"{listOfFollowers.Count} followers");

            foreach (var follower in listOfFollowers.OrderByDescending(x => x.Likes).ThenBy(x => x.Username))
            {
                Console.WriteLine($"{follower.Username}: {follower.Sum}");
            }
        }
    }
}
