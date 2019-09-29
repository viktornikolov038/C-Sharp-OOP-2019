using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var player = new Player();
        var inputFood = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Where(pf => pf != string.Empty)
            .Select(pf => FoodFactory.GetFood(pf));

        player.Eat(inputFood);

        Console.WriteLine(player);
    }

}
