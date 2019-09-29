using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Oldest_Family_Member
{
    public class Person
    {
        //FIELDS
        private int age;
        private string name;

        //PROPERTY
        //public int Age
        //{
        //    get { return this.age; }
        //    set { this.age = value; }
        //}

        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = name; }
        //}

        public int Age
        {
            get { return this.age; }
        }

        public string Name
        {
            get { return this.name; }
        }
        // CONSTRUCTOR
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
