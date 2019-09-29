using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Demo
{
    public class Program
    {
        public static void Main()
        {
            //var result = new List<Dice>();
            //while (true)
            //{
            //    var name = Console.ReadLine();
            //    if (name == "end")
            //    {
            //        break;
            //    }
            //    var age = int.Parse(Console.ReadLine());
            //    Person diceOwner = new Person(name, age);

            //    var diceType = Console.ReadLine();
            //    var sides = int.Parse(Console.ReadLine());
            //    Dice dice = new Dice(diceOwner, diceType, sides);

            //    result.Add(dice);
            //}

            //foreach (Dice dice in result)
            //{
            //    Console.WriteLine($"Owner name: {dice.Owner.Name}, owner age: {dice.Owner.Age}");
            //    Console.WriteLine("***** Dice:");
            //    Console.WriteLine($"*****  tyoe:{dice.Type}");
            //    Console.WriteLine($"*****  sides:{dice.Sides}");
            //    Console.WriteLine(dice.Roll());
            //}


            var normalDice = new Dice();
            Console.WriteLine(normalDice.Type);
        }
    }
}
