using System;

public class FireMonument : Monument
{
    public FireMonument(string name,int fireAffinity ) : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    private int FireAffinity { get;}

    public override double GetMonumentBonus()
    {
        return this.FireAffinity;
    }
}


