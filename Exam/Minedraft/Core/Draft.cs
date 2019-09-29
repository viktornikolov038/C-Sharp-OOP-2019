using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


public class Draft
{
    private List<Provider> providers;
    private List<Harvester> harvesters;
    private string id;
    public string Id { get; set; }

    public Draft()
    {
        this.providers = new List<Provider>();
        this.harvesters = new List<Harvester>();
    }

    public void AddProvider(Provider provider)
    {
        providers.Add(provider);
    }

    public void AddHarvester(Harvester harvester)
    {
        harvesters.Add(harvester);
    }

    public double GetTotalEnergy()
    {


        double totalEnergy = 0.0;
        foreach (var provider in providers)
        {
            totalEnergy += provider.EnergyOutput;
        }

        return totalEnergy;

    }

    public double GetHarvesterNeededEnergy(string mode)
    {
        double totalEnergy = 0.0;
        if (mode.Split('|')[1] == "Full")
        {
            foreach (var harvester in harvesters)
            {
                totalEnergy += harvester.EnergyRequirement;
            }

        }
        else if (mode.Split('|')[1] == "Half")
        {
            foreach (var harvester in harvesters)
            {
                totalEnergy += harvester.EnergyRequirement * 0.6;
            }
        }
        else if (mode.Split('|')[1] == "Energy")
        {
            totalEnergy = 0;
        }
        return totalEnergy;
    }

    public double CurrentDayTotalOre(string mode)
    {
        double totalOre = 0;
        if (mode == "Full")
        {
            foreach (var harvester in harvesters)
            {
                totalOre += harvester.OreOutput;
            }
        }
        else if (mode == "Half")
        {
            foreach (var harvester in harvesters)
            {
                totalOre += harvester.OreOutput * 0.5;
            }
        }
        else
        {
            totalOre = 0;
        }
        return totalOre;
    }

    public string CheckWorker(string id)
    {
        var sb = new StringBuilder();
        var isRealId = false;
        foreach (var harvester in harvesters)
        {
            if (harvester.Id == id)
            {

                sb.AppendLine($"{harvester.Type} Harvester - {harvester.Id}");
                sb.AppendLine($"Ore Output: {harvester.OreOutput}");
                sb.Append($"Energy Requirement: {harvester.EnergyRequirement}");
                isRealId = true;
                break;
            }
        }
        if (isRealId)
        {
            return sb.ToString();
        }

        foreach (var provider in providers)
        {
            if (provider.Id == id)
            {

                sb.AppendLine($"{provider.Type} Provider - {provider.Id}");
                sb.Append($"Energy Output: {provider.EnergyOutput}");
                isRealId = true;
                break;
            }
        }
        if (isRealId)
        {
            return sb.ToString();
        }

        return $"No element found with id - {id}";
    }
}

