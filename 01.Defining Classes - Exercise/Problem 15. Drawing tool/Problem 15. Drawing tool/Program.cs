using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Drawing_tool
{
    public class Program
    {
        public static void Main()
        {
            var figureToDraw = Console.ReadLine();
            if (figureToDraw == "Rectangle")
            {
                var sideA = int.Parse(Console.ReadLine());
                var sideB = int.Parse(Console.ReadLine());
                var newRecatange = new Rectangle(sideA,sideB);
                Console.WriteLine(newRecatange.Draw());
            }
            else if (figureToDraw == "Square")
            {
                var sideA = int.Parse(Console.ReadLine());
                var newSquare = new Square(sideA);
                Console.WriteLine(newSquare.Draw());
            }
        }
    }
}
