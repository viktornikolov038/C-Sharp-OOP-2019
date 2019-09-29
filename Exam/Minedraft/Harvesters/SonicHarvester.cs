using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SonicHarvester : Harvester
{
    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor,string type) : base(id, oreOutput, (energyRequirement / sonicFactor),type)
    {
        this.SonicFactor = sonicFactor;
    }
    //public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement )
    //{
    //    this.SonicFactor = sonicFactor;
    //}
    private double sonicFactor;

    public double SonicFactor
    {
        get { return this.sonicFactor; }
        private set { this.sonicFactor = value; }
    }

   
}

