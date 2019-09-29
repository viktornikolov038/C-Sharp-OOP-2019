using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsePower;
    private int acceleration;
    private int suspension;
    private int durability;
    private int performancePoints;
    private bool isParked = false;
    private bool isInRace = false;
    protected Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability, int performancePoints, bool isParked, bool isInRace)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.HorsePower = horsePower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
        this.PerformancePoints = performancePoints;
        this.IsParked = isParked;
        this.IsInRace = isInRace;
    }


    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}");
        sb.AppendLine($"{this.horsePower} HP, 100 m/h in {this.acceleration} s");
        sb.Append($"{this.suspension} Suspension force, {this.durability} Durability");

        return sb.ToString();
    }

    public bool IsInRace
    {
        get { return this.isInRace; }
        set { this.isInRace = value; }
    }
    public bool IsParked
    {
        get { return this.isParked; }
        set { this.isParked = value; }
    }
    public int PerformancePoints
    {
        get { return this.performancePoints; }
        set { this.performancePoints = value; }
    }
    public int YearOfProduction
    {
        get { return this.yearOfProduction; }
        set { this.yearOfProduction = value; }
    }
    public int HorsePower
    {
        get { return this.horsePower; }
        set { this.horsePower = value; }
    }

    public int Acceleration
    {
        get { return this.acceleration; }
        set { this.acceleration = value; }
    }

    public int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = value; }
    }

    public int Durability
    {
        get { return this.durability; }
        set { this.durability = value; }
    }

    public string Brand
    {
        get { return this.brand; }
        set { this.brand = value; }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public virtual void Tune(int tuneIndex, string tuneAddOn)
    {
        this.HorsePower = this.HorsePower + tuneIndex;
        this.Suspension = this.Suspension + tuneIndex / 2;
    }
}

