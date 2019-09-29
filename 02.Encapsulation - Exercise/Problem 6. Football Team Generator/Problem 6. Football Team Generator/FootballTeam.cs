using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6.Football_Team_Generator
{
    public class FootballTeam
    {
        public FootballTeam(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }
        private string name;
        private List<Player> players;

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

        public List<Player> Players
        {
            get { return this.players; }
            private set { this.players = value; }
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(string player)
        {
            var playerToRemove = this.Players.FirstOrDefault(p => p.Name == player);
            if (playerToRemove == null)
            {
                throw new ArgumentException($"Player {player} is not in {this.Name} team.");
            }
            this.Players.Remove(playerToRemove);
        }

        public int GetRating()
        {
            if (this.Players.Count == 0)
            {
                return 0;
            }
            double rating = this.Players.Sum(p => p.GetAvgStat());

            return (int)Math.Round(rating / this.players.Count);
        }
    }
}
