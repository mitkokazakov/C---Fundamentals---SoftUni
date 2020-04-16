using System;

namespace _02.CenterPoint
{
    class Program
    {
        static double DetermineClosestPoint(double x1,double y1)
        {
            double line = Math.Sqrt((x1 * x1) + (y1*y1));
            return line;
        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstLine = DetermineClosestPoint(x1, y1);
            double secondLine = DetermineClosestPoint(x2, y2);

            if (firstLine > secondLine)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (secondLine > firstLine)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (firstLine == secondLine)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
