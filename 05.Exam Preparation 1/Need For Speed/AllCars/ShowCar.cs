using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ShowCar : Car
{
    private int stars;


    public ShowCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability, int performancePoints, bool isParked, bool isInRace)
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability, performancePoints, isParked, isInRace)
    {
    }

    public int Stars
    {
        get { return this.stars; }
        set { this.stars = value; }
    }
    public override void Tune(int tuneIndex, String tuneAddOn)
    {
        base.Tune(tuneIndex, tuneAddOn);
        this.Stars = this.Stars + tuneIndex;
    }

    public override string ToString()
    {
        var result = base.ToString();
        var sb = new StringBuilder(result);
        sb.AppendLine();
        sb.Append($"{this.stars} *");
        return sb.ToString();
    }
}

