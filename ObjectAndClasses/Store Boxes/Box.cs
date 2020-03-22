using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Boxes
{
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox => ItemQuantity * Item.Price;

        public Box(string serialNumber, Item item, int itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;

        }

        public override string ToString()
        {
            return $"{this.SerialNumber}{Environment.NewLine}-- {this.Item.Name} - ${this.Item.Price:f2}: {this.ItemQuantity}{Environment.NewLine}-- ${this.PriceForABox:f2}";
        }
    }
}
