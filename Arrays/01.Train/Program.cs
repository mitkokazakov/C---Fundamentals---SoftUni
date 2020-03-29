using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWagons = int.Parse(Console.ReadLine());
            int[] Wagons = new int[countWagons];
            int sum = 0;

            for (int i = 0; i < countWagons; i++)
            {
                Wagons[i] = int.Parse(Console.ReadLine()); 
            }

            foreach (int people in Wagons)
            {
                Console.Write(people + " ");
                sum += people;
            }

            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
