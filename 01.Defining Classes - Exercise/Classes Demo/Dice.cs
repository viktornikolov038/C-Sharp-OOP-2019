using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Demo
{
    class Dice
    {
        //fields - poleta
        private int sides;
        private string type;
        private Person owner;
        private Random rnd = new Random();


        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public Person Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        //method
        public int Roll()
        {
            int rollNext = rnd.Next(1, this.sides + 1);
            return rollNext;
        }
        // constructor
        public Dice()
        {
            this.owner = new Person();
            this.type = "6 sided";
            this.sides = 6;
        }
        public Dice(Person owner, string type, int sides)
        {
            this.owner = owner;
            this.type = type;
            this.sides = sides;
        }
    }
}
