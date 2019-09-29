public class MoodFactory
{
    public static Mood GetMood(int points)
    {
        if (points < -5)
        {
            return new Angry(points);
        }
        else if (points >= -5 && points <= 0)
        {
            return new Sad(points);
        }
        else if (points >= 1 && points <= 15)
        {
            return new Happy(points);
        }
        else
        {
            return new JavaScript(points);
        }
    }
}

