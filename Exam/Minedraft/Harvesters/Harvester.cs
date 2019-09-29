using System;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;
    private string type;
    public string Type { get; set; }
    public Harvester(string id, double oreOutput, double energyRequirement,string type)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
        this.Type = type;
    }

    public virtual double EnergyRequirement
    {
        get { return this.energyRequirement; }
        private set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
            }
            this.energyRequirement = value;
        }
    }

    public double OreOutput 
    {
        get { return this.oreOutput; }
        private set
        {
            if (value < 0 )
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(OreOutput)}");
            }
            this.oreOutput = value;
        }
    }

    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }

}

