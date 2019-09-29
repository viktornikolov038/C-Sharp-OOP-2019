using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool, List<Car> participants, string type)
        : base(length, route, prizePool, participants,type)
    {
    }
}

