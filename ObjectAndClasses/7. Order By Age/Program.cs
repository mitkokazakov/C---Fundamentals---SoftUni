using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Order_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] personInfo = input.Split();
                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = new Person(name, id, age);
                people.Add(person);

                input = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, people));
        }
    }
}
