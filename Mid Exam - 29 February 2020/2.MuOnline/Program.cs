using System;
using System.Linq;

namespace _2.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialBitcoins = 0;
            bool finished = false;
            string[] rooms = Console.ReadLine().Split("|");

            for (int i = 0; i < rooms.Length; i++)
            {
                

                string[] currentRoom = rooms[i].Split();

                string command = currentRoom[0];
                int number = int.Parse(currentRoom[1]);

                if (command == "potion")
                {

                        if (number > 100 - initialHealth)
                        {
                            number = 100 - initialHealth;
                            Console.WriteLine($"You healed for {number} hp.");
                            initialHealth += number;
                        }
                        else if (number <= 100 - initialHealth)
                        {
                            Console.WriteLine($"You healed for {number} hp.");
                            initialHealth += number;
                        }
                    

                    
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    initialBitcoins += number;
                }
                else
                {
                    initialHealth -= number;

                    if (initialHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i+1}");
                        finished = true;
                        break;

                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                        
                    }
                    
                }
            }

            if (finished == false)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}
