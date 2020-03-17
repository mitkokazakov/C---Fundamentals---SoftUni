using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            List<string> furnitures = new List<string>();

            while (input != "Purchase")
            {
                if (input == "Purchase")
                {
                    break;
                }
                Regex regex = new Regex(@">>(.+)<<(\d+\.?\d*)!(\d+)");

                var matches = regex.Match(input);
                if (matches.Length > 0)
                {
                    furnitures.Add(matches.Groups[1].Value);
                    double price = double.Parse(matches.Groups[2].Value);
                    double quantity = double.Parse(matches.Groups[3].Value);
                    sum += price * quantity;
                }
                

                input = Console.ReadLine();
            }


            Console.WriteLine("Bought furniture:");
            foreach (var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
