using System;

namespace _1._Gift_Box_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            int numOfSheets = int.Parse(Console.ReadLine());
            double singleSheet = double.Parse(Console.ReadLine());

            double areaBox = 6 * side * side;

            int numOfSmallestSheets = numOfSheets / 3;

            double areaCoveredFromNormalSheets = (numOfSheets - numOfSmallestSheets) * singleSheet;

            double areaCoveredFromSmallestSheets = singleSheet * 0.25 * numOfSmallestSheets;

            double totalAreaCovered = areaCoveredFromNormalSheets + areaCoveredFromSmallestSheets;

            double percentage = (totalAreaCovered / areaBox) * 100;

            Console.WriteLine($"You can cover {percentage:f2}% of the box.");

        }
    }
}
