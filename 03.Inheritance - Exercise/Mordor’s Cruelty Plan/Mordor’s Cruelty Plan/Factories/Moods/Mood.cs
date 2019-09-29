public abstract class Mood
{
    public Mood(int pointsOfHappiness)
    {
        this.PointsOfHappiness = pointsOfHappiness;
    }

    public int PointsOfHappiness { get; private set; }
}

