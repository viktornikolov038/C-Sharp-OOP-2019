using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


public class DraftManager
{
    private Dictionary<string, Draft> workers;
    private List<Draft> checker;
    private double totalEnergyStored;
    private double totalOreStored;
    private string mode = "Full";
    public DraftManager()
    {
        this.workers = new Dictionary<string, Draft>()
            {
                {"Sonic", new Draft()},
                {"Hammer",new Draft() },
                {"Solar",new Draft() },
                {"Pressure",new Draft() }
            };
        this.totalEnergyStored = 0;
    }
    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);

        if (energyRequirement > 20000 || energyRequirement < 0)
        {
            throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement");
        }

        switch (type)
        {
            case "Sonic":
                var sonicFactor = int.Parse(arguments[4]);
                this.workers[type].AddHarvester(new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor,"Sonic"));
                break;
            case "Hammer":
                this.workers[type].AddHarvester(new HammerHarvester(id, oreOutput, energyRequirement,"Hammer"));
                break;
        }
        return $"Successfully registered {type} Harvester - {id}";
    }
    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);
        switch (type)
        {
            case "Solar":
                this.workers[type].AddProvider(new SolarProvider(id,energyOutput,"Solar"));
                break;
            case "Pressure":
                this.workers[type].AddProvider(new PressureProvider(id,energyOutput,"Pressure"));
                break;
        }
        return $"Successfully registered {type} Provider - {id}";
    }
    public string Day()
    {
        var currentDayEnergyStored = 0.0;
        var solarEnergy = workers["Solar"].GetTotalEnergy();
        var pressureEnergy = workers["Pressure"].GetTotalEnergy();
        currentDayEnergyStored = solarEnergy + pressureEnergy;
        this.totalEnergyStored += currentDayEnergyStored;
        var sonicEnergyNeeded = workers["Sonic"].GetHarvesterNeededEnergy(mode);
        var hammerEnergyNeeded = workers["Hammer"].GetHarvesterNeededEnergy(mode);
        var neededEnergy = sonicEnergyNeeded + hammerEnergyNeeded;
        var currentDayOre = workers["Sonic"].CurrentDayTotalOre(mode) + workers["Hammer"].CurrentDayTotalOre(mode);
        //totalOreStored += workers["Sonic"].CurrentDayTotalOre(mode) + workers["Hammer"].CurrentDayTotalOre(mode);
        var result = new StringBuilder();
        
        if (neededEnergy <= totalEnergyStored)
        {
            result.AppendLine("A day has passed.");
            result.AppendLine($"Energy Provided: {currentDayEnergyStored}");
            result.Append($"Plumbus Ore Mined: {currentDayOre}");
            this.totalEnergyStored -= neededEnergy;
            totalOreStored += currentDayOre;
        }
        else
        {
            result.AppendLine("A day has passed.");
            result.AppendLine($"Energy Provided: {currentDayEnergyStored}");
            result.Append($"Plumbus Ore Mined: 0");
        }
        return result.ToString();
    }
    public string Mode(List<string> arguments)
    {
        mode = arguments[0];
       
        return $"Successfully changed working mode to {mode} Mode|{mode}";
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        var result = "";
        var mustBreak = false;
        foreach (var worker in workers)
        {
            result = worker.Value.CheckWorker(id);
            if (result.Split()[0] != "No")
            {
                return result;
            }
            else
            {
                mustBreak = false;
            }
        }
        return result;
    }
    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalEnergyStored}");
        sb.Append($"Total Mined Plumbus Ore: {this.totalOreStored}");
        return sb.ToString();
    }

}

