using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    class Product
    {
        public string NameOfProduct { get; set; }
        public int Cost { get; set; }

        public Product(string nameProduct, int cost)
        {
            this.NameOfProduct = nameProduct;
            this.Cost = cost;
        }
    }
}
