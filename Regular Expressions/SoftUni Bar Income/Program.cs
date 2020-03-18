using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%.*?<(\w+)>.*?\|(\d+)\|.*?(\d+\.?\d*)\$";
            

            string input = Console.ReadLine();

            double totalPrice = 0;

            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);

                var validOrder = regex.Match(input);
                if (validOrder.Length > 0)
                {
                    string customerName = validOrder.Groups[1].Value;
                    string product = validOrder.Groups[2].Value;
                    int count = int.Parse(validOrder.Groups[3].Value);
                    double price = double.Parse(validOrder.Groups[4].Value);
                    double currentPrice = count * 1.0 * price;
                    totalPrice += currentPrice;

                    Console.WriteLine($"{customerName}: {product} - {currentPrice:f2}");
                }
                

                

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
