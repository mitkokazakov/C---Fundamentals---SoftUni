using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Boxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string itemName, decimal itemPrice)
        {
            this.Name = itemName;
            this.Price = itemPrice;
        }
    }
}
