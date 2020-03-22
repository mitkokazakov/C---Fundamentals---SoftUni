using System;
using System.Linq;
using System.Collections.Generic;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < count; i++)
            {
                string[] familyInfo = Console.ReadLine().Split();
                string name = familyInfo[0];
                int age = int.Parse(familyInfo[1]);

                Person person = new Person(name,age);
                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestPerson();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
            
        }
    }
}
