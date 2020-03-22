using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    class Person
    {
        public string Name { get; set; }
        public int Money { get; set; }
        //public Product Product { get; set; }
        public List<string> BagProducts { get; set; }

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            //this.Product = product;
            this.BagProducts = new List<string>();
        }

        public void BuyingProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.BagProducts.Add(product.NameOfProduct);
                Console.WriteLine($"{this.Name} bought {product.NameOfProduct}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.NameOfProduct}");
            }
        }
    }
}
