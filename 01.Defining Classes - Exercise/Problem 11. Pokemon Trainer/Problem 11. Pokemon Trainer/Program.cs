using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Problem_11.Pokemon_Trainer
{
    public class Program
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();
            while (true)
            {
                var trainerInput = Console.ReadLine();
                if (trainerInput == "Tournament")
                {
                    break;
                }
                var trainerArgs = trainerInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentTrainer = new Trainer(trainerArgs[0]);
                var currentPokemon = new Pokemon(trainerArgs[1], trainerArgs[2], int.Parse(trainerArgs[3]));
                currentTrainer.Pokemons.Add(currentPokemon);
                if (trainers.Any(t => t.Name == currentTrainer.Name))
                {
                    trainers.First(t => t.Name == currentTrainer.Name).Pokemons.Add(currentPokemon);
                }
                else
                {
                    trainers.Add(currentTrainer);
                }
            }

            while (true)
            {
                var elementInput = Console.ReadLine();
                if (elementInput == "End")
                {
                    break;
                }
                foreach (var trainer in trainers)
                {

                    if (trainer.Pokemons.Any(p => p.Element == elementInput))
                    {
                        trainer.NumberOfBadges += 1;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons.ToArray())
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health <= 0)
                            {
                                var toRemove = trainer.Pokemons.FirstOrDefault(p => p.Name == pokemon.Name);
                                trainer.Pokemons.Remove(toRemove);
                            }
                        }
                    }
                }


            }
            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
