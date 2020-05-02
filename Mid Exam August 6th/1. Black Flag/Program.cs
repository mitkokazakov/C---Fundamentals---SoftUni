using System;

namespace _1._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double sumPlunder = 0;
            
            

            for (int i = 1; i <= numOfDays; i++)
            {
                sumPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    sumPlunder += dailyPlunder * 0.5;
                }
                if (i % 5 == 0)
                {
                    sumPlunder = sumPlunder - (sumPlunder * 0.3);
                }
                
            }

            if (sumPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {sumPlunder:f2} plunder gained.");
            }
            else
            {
                double percentagePlunder = (sumPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentagePlunder:f2}% of the plunder.");
            }
        }
    }
}
