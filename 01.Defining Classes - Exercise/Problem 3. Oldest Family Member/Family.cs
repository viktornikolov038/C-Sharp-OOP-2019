using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Oldest_Family_Member
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person currentPerson)
        {
            this.people.Add(currentPerson);
        }

        public void AddOlderThan30(Person currentPerson)
        {
            if (currentPerson.Age > 30)
            {
                this.people.Add(currentPerson);
            }
        }
        public Person GetOldestMember()
        {
            return this.people.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public override string ToString()
        {
            if (people.Any())
            {
                foreach (Person person in this.people.OrderBy(p => p.Name))
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");                    
                }
            }

            return null;

        }
    }
}
