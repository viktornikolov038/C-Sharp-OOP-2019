using System;

public class Dog : Animal
{
    public Dog(string name, string favouriteFood) : base(name,favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }


    public override string ExplainMyself()
    {
        return "Djaf";
    }
}

