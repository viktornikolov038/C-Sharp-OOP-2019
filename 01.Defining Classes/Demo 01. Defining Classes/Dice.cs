using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01.Defining_Classes
{
    class Dice
    {
        private int sizes;
        private string color;
        private Random rnd = new Random();
        public Dice(int sizes)
        {
            this.sizes = sizes;
        }

        public Dice(int sizes, string color)
        {
            this.sizes = sizes;
            this.color = color;
        }

        public int Sizes
        {
            get { return this.sizes; }
        }
        public int Roll()
        {
            return this.rnd.Next(1, this.Sizes);
        }
        

        public string Color
        {
            get { return this.color; }
        }
    
    }
}
