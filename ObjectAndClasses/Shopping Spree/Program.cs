using System;
using System.Linq;
using System.Collections.Generic;

namespace Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();
            List<Product> listOfProducts = new List<Product>();

            string[] personDetails = Console.ReadLine().Split(";");
            string[] productDetails = Console.ReadLine().Split(";");

            for (int i = 0; i < personDetails.Length; i++)
            {
                string[] currentPerson = personDetails[i].Split("=");
                string name = currentPerson[0];
                int money = int.Parse(currentPerson[1]);

                Person person = new Person(name,money);
                listOfPersons.Add(person);
            }

            for (int i = 0; i < productDetails.Length; i++)
            {
                string[] currentProduct = productDetails[i].Split("=");
                string nameProduct = currentProduct[0];
                int cost = int.Parse(currentProduct[1]);

                Product product = new Product(nameProduct, cost);
                listOfProducts.Add(product);
            }

            string commands = Console.ReadLine();

            while (commands != "END")
            {
                string[] commandsArg = commands.Split();
                string namePerson = commandsArg[0];
                string nameProduct = commandsArg[1];

                Person existPerson = listOfPersons.Find(x => x.Name == namePerson);
                Product existProduct = listOfProducts.Find(x => x.NameOfProduct == nameProduct);

                existPerson.BuyingProduct(existProduct);

                commands = Console.ReadLine();
            }

            foreach (Person person in listOfPersons)
            {
                Console.Write($"{person.Name} - ");
                if (person.BagProducts.Count == 0)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                {
                    Console.WriteLine(String.Join(", ", person.BagProducts));
                }
                

                //foreach (var bags in person.BagProducts)
                //{
                //    Console.Write($"");
                //}
            }
        }
    }
}
