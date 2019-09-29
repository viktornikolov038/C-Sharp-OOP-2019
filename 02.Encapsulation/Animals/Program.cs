using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation_Demo;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("ivan", 20);
            Console.WriteLine(cat.Name);
        }
    }
}
