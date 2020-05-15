using System;
using System.Linq;
using System.Collections.Generic;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> regForm = new Dictionary<string, User>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] userInfo = input.Split();
                string town = userInfo[0];
                string name = userInfo[1];
                string gender = userInfo[2];
                int age = int.Parse(userInfo[3]);

                User user = new User(name, gender, age);

                if (!regForm.ContainsKey(town))
                {
                    regForm[town] = user;
                }

                if (regForm[town].Name == name)
                {
                    User existUser = regForm[town];
                    existUser.ChangeYears(age);
                }

                input = Console.ReadLine();
            }

            foreach (var user in regForm)
            {
                Console.WriteLine($"{user.Value.Name} is from {user.Key} --- {user.Value.Gender} --- {user.Value.Age}!");
            }
        }
    }
}
