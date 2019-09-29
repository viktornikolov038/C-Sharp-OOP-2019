using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PerformanceCar : Car
{
    private List<string> addOnes = new List<string>();


    public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability, int performancePoints, bool isParked, bool isInRace)
        : base(brand, model, yearOfProduction, (int)(horsePower * 1.5), acceleration, suspension -(int)(suspension * 0.25), durability, performancePoints, isParked, isInRace)
    {
    }

    public override void Tune(int tuneIndex, string tuneAddOn)
    {
        base.Tune(tuneIndex, tuneAddOn);
        this.addOnes.Add(tuneAddOn);
    }

    public override string ToString()
    {
        var result = base.ToString();
        var sb = new StringBuilder(result);
        sb.AppendLine();
        if (this.addOnes.Count > 0)
        {
            sb.Append($"Add-ons: {string.Join(", ", this.addOnes)}");
        }
        else
        {
            sb.Append("Add-ons: None");
        }
        return sb.ToString();
    }
}

