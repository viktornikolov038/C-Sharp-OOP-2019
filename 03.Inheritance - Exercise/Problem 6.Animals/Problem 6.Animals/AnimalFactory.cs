using System;

public class AnimalFactory
{
    public static Animal GetAnimal(string type, string name, int age, string gender = null)
    {
        switch (type.ToLower())
        {
            case "dog":
                return new Dog(name,age,gender);
            case "cat":
                return new Cat(name,age, gender);
            case "frog":
                return new Frog(name,age,gender);
            case "kitten":
                return new Kitten(name,age);
            case "tomcat":
                return new Tomcat(name,age);
            default:
                throw new ArgumentException("Invalid input!");

        }
    }
}

