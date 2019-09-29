using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Demo
{
    public class Dog : Animal
    {
        private string name;
        private int age;
        

        public Dog(string name, int age)
            :base()
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public string SayHello()
        {
            return "Bau !!!";
        }
    }
}
