using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Demo
{
    public class Animal
    {
        private int numberOfLegs;

        public Animal()
        {
            this.NumberOfLegs = 4;
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            protected set { this.numberOfLegs = value; }
        }
    }
}
