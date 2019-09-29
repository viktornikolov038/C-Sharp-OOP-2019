using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;
    private string type;

    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }


    protected Race(int length, string route, int prizePool, List<Car> participants,string type)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = participants;
        this.Type = type;
    }

    public void AddCarsToRace(Car car)
    {
        participants.Add(car);
    }

    public List<Car> Participants
    {
        get { return this.participants; }
        set { this.participants = value; }
    }

    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        set { this.prizePool = value; }
    }
}

