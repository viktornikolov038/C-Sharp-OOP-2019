using System;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput,string type) : base(id, energyOutput * 0.5 + energyOutput,type)
    {
    }
}

