using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ItemProp> orders = new Dictionary<string, ItemProp>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] inputArg = input.Split();
                string item = inputArg[0];
                double price = double.Parse(inputArg[1]);
                int quantity = int.Parse(inputArg[2]);

                

                ItemProp itemProp = new ItemProp(item, price, quantity);
                
                if (!orders.ContainsKey(item))
                {
                    
                    orders.Add(item, itemProp);
                }
                else
                {
                    ItemProp existItem = orders[item];
                    existItem.AddQuantity(quantity,price);
                   
                }

                input = Console.ReadLine();
            }

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.FinalPrice:f2}");
            }
        }
    }
}
