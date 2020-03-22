using System;
using System.Linq;
using System.Collections.Generic;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputInfo = Console.ReadLine();
            List<Box> listOfBoxes = new List<Box>();

            while (inputInfo != "end")
            {
                string[] data = inputInfo.Split();
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);

                listOfBoxes.Add(box);

                inputInfo = Console.ReadLine();
            }

            listOfBoxes = listOfBoxes.OrderByDescending(x => x.PriceForABox).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, listOfBoxes));
        }
    }
}
