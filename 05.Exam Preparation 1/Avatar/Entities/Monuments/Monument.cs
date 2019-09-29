using System;

public abstract class Monument
{
    
    protected Monument(string name)
    {
        this.Name = name;
    }

    public string Name { get; private set; }

    public abstract double GetMonumentBonus();
}

