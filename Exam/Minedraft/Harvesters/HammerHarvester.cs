using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement,string type) : base(id, oreOutput * 2 + oreOutput, energyRequirement * 2,type)
    {
    }

    
}

