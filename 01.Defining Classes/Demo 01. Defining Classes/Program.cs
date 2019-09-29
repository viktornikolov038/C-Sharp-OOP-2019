using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01.Defining_Classes
{
    public class Program
    {
        public static void Main()
        {
            var redDice = new Dice(6,"red");
            var justDice = new Dice(6);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(redDice.Roll());
            }
        }
    }
}
