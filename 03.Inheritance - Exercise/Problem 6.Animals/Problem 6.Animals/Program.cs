using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var animals = new List<Animal>();
        while (true)
        {
            var typeInput = Console.ReadLine();
            if (typeInput == "Beast!")
            {
                break;
            }

            var animalInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = animalInfo[0];
            var age = int.Parse(animalInfo[1]);

            var gender = animalInfo[2];


            try
            {
                var animal = AnimalFactory.GetAnimal(typeInput, name, age, gender);
                animals.Add(animal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine,animals));
    }
}

