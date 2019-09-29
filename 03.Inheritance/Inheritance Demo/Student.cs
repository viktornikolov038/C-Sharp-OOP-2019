using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Person
    {
        private string town;

        public string Town
        {
            get { return this.town; }
            set { this.town = value; }
        }

    }
}
