using System;
using System.Collections.Generic;
using System.Text;

namespace Registration
{
    class User
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public User(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public void ChangeYears(int age)
        {
            this.Age = age;
        }
    }
}
