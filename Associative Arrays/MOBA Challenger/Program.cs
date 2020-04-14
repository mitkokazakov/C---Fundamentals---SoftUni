using System;
using System.Linq;
using System.Collections.Generic;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                if (!input.Contains("vs"))
                {
                    string[] info = input.Split(" -> ");
                    string name = info[0];
                    string position = info[1];
                    int skills = int.Parse(info[2]);

                    if (!players.ContainsKey(name))
                    {
                        players[name] = new Dictionary<string, int>();
                    }

                    if (!players[name].ContainsKey(position))
                    {
                        players[name].Add(position, skills);
                    }
                    

                    if (players[name].ContainsKey(position) && players[name][position] < skills)
                    {
                        players[name][position] = skills;
                    }
                    //else
                    //{
                    //    players[name].Add(position, skills);
                    //}
                }
                else
                {
                    string[] battle = input.Split(" vs ");
                    string firstPlayer = battle[0];
                    string secondPlayer = battle[1];

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        string playerToRemove = "";

                        foreach (var position1 in players[firstPlayer])
                        {
                            foreach (var position2 in players[secondPlayer])
                            {
                                if (position1.Key == position2.Key)
                                {
                                    if (players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum())
                                    {
                                        playerToRemove = secondPlayer;
                                    }
                                    else if (players[firstPlayer].Values.Sum() < players[secondPlayer].Values.Sum())
                                    {
                                        playerToRemove = firstPlayer;
                                    }
                                }
                            }
                        }
                        players.Remove(playerToRemove);
                    }
                }



                input = Console.ReadLine();
            }

            foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
