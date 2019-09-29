using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Demo
{
    public class Cat : Animal
    {
        private string name;
        private int age;

        public Cat(string name, int age)
            :base()
        {
            this.name = name;
            this.age = age;
            this.NumberOfLegs = 8;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name cannot be less then 3 symbols ");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public string SayHello()
        {
            return "Mql !!!";
        }
    }
}
