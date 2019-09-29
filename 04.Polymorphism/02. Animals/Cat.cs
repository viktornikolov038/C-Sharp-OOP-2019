using System;

public class Cat : Animal
{
    public Cat(string name,string favouriteFood) : base(name,favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    public override string ExplainMyself()
    {
        return "MEEOW";
    }

}
