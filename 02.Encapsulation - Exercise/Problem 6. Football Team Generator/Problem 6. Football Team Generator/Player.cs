using System;
using System.Linq;

namespace Problem_6.Football_Team_Generator
{
    public class Player
    {
        public Player(string name,int[] stats)
        {
            this.Name = name;
            this.Stats = stats;
        }
        private string[] statNames = new[] {"Endurance", "Sprint", "Dribble", "Passing", "Shooting"};

        private string name;
        private int[] stats = new int[5];
        public int[] Stats
        {
            get { return stats; }
            private set
            {

                for (int i = 0; i < 5; i++)
                {
                    if (value[i] < 0 || value[i] > 100)
                    {
                        throw new ArgumentException($"{this.statNames[i]} should be between 0 and 100.");
                    }
                    this.stats[i] = value[i];
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public int GetAvgStat()
        {
            return (int)Math.Round(this.Stats.Average());
        }
    }
}
