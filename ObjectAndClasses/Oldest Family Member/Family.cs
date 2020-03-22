using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Oldest_Family_Member
{
    class Family
    {
        public List<Person> FamilyList { get; set; }

        public Family()
        {
            this.FamilyList = new List<Person>();
        }

        public void AddMember(Person person)
        {
            FamilyList.Add(person);
        }

        public Person GetOldestPerson()
        {
            return this.FamilyList.OrderByDescending(x => x.Age).First();
        }
    }
}
