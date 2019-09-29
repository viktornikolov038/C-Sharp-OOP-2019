using System;

public class WaterMonument : Monument
{
    public WaterMonument(string name,int waterAffinity ) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    private int WaterAffinity  { get; }

    public override double GetMonumentBonus()
    {
        return this.WaterAffinity;
    }
}

