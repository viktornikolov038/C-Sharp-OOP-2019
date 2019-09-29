using System;

public class EarthMonument : Monument
{
    public EarthMonument(string name, int earthAffinity ) : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    private int EarthAffinity  { get;}

    public override double GetMonumentBonus()
    {
        return this.EarthAffinity;
    }
}

