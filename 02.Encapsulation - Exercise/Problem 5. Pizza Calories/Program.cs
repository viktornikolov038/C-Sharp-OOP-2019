using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Pizza_Calories
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                var input = Console.ReadLine();
                var outputOptions = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (outputOptions[0] == "Pizza")
                {
                    while (true)
                    {
                        if (input == "END")
                        {
                            break;
                        }
                        var pizzaInput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var pizza = new Pizza(pizzaInput[1], int.Parse(pizzaInput[2]));
                        var doughInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var dough = new Dough(doughInput[1].ToLower(), doughInput[2].ToLower(),
                            double.Parse(doughInput[3]));
                        pizza.AddDough(dough);
                        for (int i = 0; i < int.Parse(pizzaInput[2]); i++)
                        {
                            var toppingInput = Console.ReadLine()
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            var topping = new Topping(toppingInput[1].ToLower(), double.Parse(toppingInput[2]));
                            pizza.AddToppings(topping);
                        }

                        Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");

                        input = Console.ReadLine();
                    }
                }else
                {
                    while (true)
                    {
                        if (input == "END")
                        {
                            break;
                        }

                        var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (tokens[0] == "Dough")
                        {
                            var dough = new Dough(tokens[1].ToLower(),tokens[2].ToLower(),double.Parse(tokens[3]));
                            Console.WriteLine($"{dough.GetCalories():f2}");
                        }
                        else
                        {
                            var topping = new Topping(tokens[1].ToLower(),double.Parse(tokens[2]));
                            Console.WriteLine($"{topping.GetToppingCalories():f2}");
                        }


                        input = Console.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}
