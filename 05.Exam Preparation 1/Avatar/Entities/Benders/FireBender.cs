using System;

public class FireBender : Bender
{
    public FireBender(string name, int power, double heatAggression ) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public double HeatAggression  { get; private set; }
    public override double GetTotalPower()
    {
        return this.HeatAggression * base.Power;
    }
}

