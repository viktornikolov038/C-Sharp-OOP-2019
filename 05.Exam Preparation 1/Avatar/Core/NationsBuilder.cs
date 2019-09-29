using System;
using System.Collections.Generic;
using Avatar.Entities;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>
        {
            { "Air", new Nation(), },
            { "Earth", new Nation(), },
            { "Fire", new Nation(), },
            { "Water", new Nation(), },
        };
    }


    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var secondaryParameter = double.Parse(benderArgs[3]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddBender(new AirBender(name, power, secondaryParameter));
                break;
            case "Fire":
                this.nations[type].AddBender(new FireBender(name,power,secondaryParameter));
                break;
        }

    }
    public void AssignMonument(List<string> monumentArgs)
    {
        //TODO: Add some logic here … 
    }
    public string GetStatus(string nationsType)
    {
        return "";
    }
    public void IssueWar(string nationsType)
    {
        //TODO: Add some logic here … 
    }
    public string GetWarsRecord()
    {
        return "";
    }

}

