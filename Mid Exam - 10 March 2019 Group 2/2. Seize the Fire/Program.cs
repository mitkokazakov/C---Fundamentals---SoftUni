using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cellsInfo = Console.ReadLine().Split("#");
            int water = int.Parse(Console.ReadLine());
            List<int> putedOutCells = new List<int>();
            double effort = 0;
            int totalFire = 0;
            int counter = 0;


            for (int i = 0; i < cellsInfo.Length; i++)
            {
                if (water <= 0)
                {
                    break;
                }


                string currentCell = cellsInfo[i];
                string[] oneCellInfo = currentCell.Split(" = ");
                string levelOfFire = oneCellInfo[0];
                int valueOfFire = int.Parse(oneCellInfo[1]);

                if (levelOfFire == "High")
                {
                    if (valueOfFire >= 81 && valueOfFire <= 125 && water >= valueOfFire)
                    {
                        PutOutCell(ref water, putedOutCells, ref effort, ref totalFire, valueOfFire);
                    }
                }
                else if (levelOfFire == "Medium")
                {
                    if (valueOfFire >= 51 && valueOfFire <= 80 && water >= valueOfFire)
                    {
                        PutOutCell(ref water, putedOutCells, ref effort, ref totalFire, valueOfFire);
                    }
                }
                else if (levelOfFire == "Low")
                {
                    if (valueOfFire >= 1 && valueOfFire <= 50 && water >= valueOfFire)
                    {
                        PutOutCell(ref water, putedOutCells, ref effort, ref totalFire, valueOfFire);
                    }
                }


            }



            Console.WriteLine("Cells:");
            foreach (var cell in putedOutCells)
            {
                Console.WriteLine($"- {cell}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }

        private static void PutOutCell(ref int water, List<int> putedOutCells, ref double effort, ref int totalFire, int valueOfFire)
        {
            water -= valueOfFire;
            putedOutCells.Add(valueOfFire);
            effort += valueOfFire * 0.25;
            totalFire += valueOfFire;
        }
    }
}
