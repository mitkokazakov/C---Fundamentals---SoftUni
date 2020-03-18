using System;

namespace _1.Biscuits_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsAmount = int.Parse(Console.ReadLine());

            int countWorkers = int.Parse(Console.ReadLine());

            int otherFactoryProduction = int.Parse(Console.ReadLine());

            int productionForOneDay = countWorkers * biscuitsAmount;
            double everyThirdDayProduction = Math.Floor((productionForOneDay * 0.75));

            double totalProduction = (10 * everyThirdDayProduction) + (20 * productionForOneDay);
            totalProduction = Convert.ToInt32(totalProduction);

            Console.WriteLine($"You have produced {totalProduction} biscuits for the past month.");

            if (totalProduction > otherFactoryProduction)
            {
                double percentage = ((totalProduction - otherFactoryProduction) / otherFactoryProduction) * 100;
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else if (totalProduction < otherFactoryProduction)
            {
                double percentage = ((otherFactoryProduction - totalProduction) / otherFactoryProduction) * 100;
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }


            
        }
    }
}
