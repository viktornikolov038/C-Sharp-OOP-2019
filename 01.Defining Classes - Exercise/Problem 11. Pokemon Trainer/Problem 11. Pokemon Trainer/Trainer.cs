using System.Collections.Generic;

namespace Problem_11.Pokemon_Trainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();   
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
