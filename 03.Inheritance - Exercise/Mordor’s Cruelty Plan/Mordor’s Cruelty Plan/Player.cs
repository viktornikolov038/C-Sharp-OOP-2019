using System;
using System.Collections.Generic;

public class Player
{
    public int PointsOfHappiness { get; private set; }

    public Mood GetMood()
    {
        return MoodFactory.GetMood(this.PointsOfHappiness);
    }

    public void Eat(IEnumerable<Food> foods)
    {
        foreach (var food in foods)
        {
            this.PointsOfHappiness += food.PointsOfHappines;
        }
    }

    public override string ToString()
    {
        var mood = this.GetMood();
        return $"{PointsOfHappiness}{Environment.NewLine}{mood}";
    }
}

