using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog("Goshko","Meat");
        Animal cat = new Cat("Ivan","Java");

        var listOfAnimals = new List<Animal>();
        listOfAnimals.Add(cat);
        listOfAnimals.Add(dog);

        Print(listOfAnimals);
    }

    public static void Print(List<Animal> animals)
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ExplainMyself());
            animal.DoSmth();
        }
    }
}

