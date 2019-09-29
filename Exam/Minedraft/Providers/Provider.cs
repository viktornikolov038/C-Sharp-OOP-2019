using System;

public abstract class Provider
{
    private string id;
    private double energyOutput;
    private string type;
    public string Type { get; set; }
    public Provider(string id, double energyOutput,string type)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
        this.Type = type;
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        private set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }

    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }

    //public double GetTotalEnergy()
    //{
        
    //}
}

