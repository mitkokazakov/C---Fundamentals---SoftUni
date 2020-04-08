using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Orders
{
    class ItemProp
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double FinalPrice => this.Price * this.Quantity;

        public ItemProp(string itemName, double price, int quantity)
        {
            this.ItemName = itemName;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void AddQuantity(int quantity, double price)
        {
            this.Quantity += quantity;
            this.Price = price;
        }
    }
}
