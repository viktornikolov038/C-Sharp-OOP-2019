using System;

public class AirMonument : Monument
{
    public AirMonument(string name,int airAffinity) : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    private int AirAffinity { get; }

    public override double GetMonumentBonus()
    {
        return this.AirAffinity;
    }
}

