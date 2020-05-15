using System;
using System.Collections.Generic;
using System.Linq;

namespace Roulette
{
    class Program
    {
        public const int numOfOursNumbers = 14;
        public const int numOfDraws = 10;
        public const int coeff = 36;

        static void Main(string[] args)
        {


            int[] ourNumbers = new int[numOfOursNumbers] { 1, 4, 7, 9, 13, 15, 18, 20, 22, 24, 28, 31, 33, 36 };
            int[] betsPerNumber = new int[numOfDraws] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int drawnNumber = 0;
            double bets = 0;
            double profit = 0;
            int counter = 0;
            double nextBet = 0;

            List<int> drawnNumbers = new List<int>();

            for (int i = 0; i < numOfDraws; i++)
            {
                Random random = new Random();
                drawnNumber = random.Next(0, 37);
                drawnNumbers.Add(drawnNumber);

                if (counter == 1)
                {
                    bets += nextBet * numOfOursNumbers;
                    counter = 0;
                }
                else if (counter == 0)
                {
                    bets += betsPerNumber[i] * numOfOursNumbers;
                }
                

                if (ourNumbers.Contains(drawnNumber))
                {
                    profit = betsPerNumber[i] * coeff - bets;

                    counter++;

                    nextBet = (profit + numOfOursNumbers) / 14;
                    
                }
                
            }
            Console.WriteLine($"Proffit: {profit}");
            Console.WriteLine("Drawn numbers:");
            Console.WriteLine(String.Join(Environment.NewLine, drawnNumbers));
        }
    }
}
