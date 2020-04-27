using System;

namespace _1._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            int countOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());
           
           
            double totalWater = numOfDays * countOfPlayers * waterPerDay;
            double totalFood = numOfDays * countOfPlayers * foodPerDay;
            bool alreadyFinish = false;

            for (int i = 1; i <= numOfDays; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;

                if (groupEnergy <= 0)
                {
                    alreadyFinish = true;
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    break;
                }
              
                if (i % 2 == 0)
                {
                    groupEnergy = groupEnergy + (groupEnergy * 0.05);
                    totalWater = totalWater - (totalWater * 0.3);
                    
                }
                if (i % 3 == 0)
                {
                    totalFood -= totalFood / countOfPlayers * 1.0;
                    groupEnergy = groupEnergy + (groupEnergy * 0.1);
                    
                }
            }

            if (alreadyFinish == false)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
        }
    }
}
