using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_a_class_Person
{
    class Person
    {
        public string name;
        public int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = age; }
        }

        public Person()
        {
            this.age = 1;
            this.name = "No name";
        }

        public Person(int age)
        {
            this.age = age;
            this.name = "No name";
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
