using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6.Football_Team_Generator
{
    public class Program
    {
        public static void Main()
        {

            var teams = new List<FootballTeam>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                var inputArgs = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputArgs[0] == "Team")
                {
                    teams.Add(new FootballTeam(inputArgs[1]));
                }
                var currentTeam = teams.FirstOrDefault(t => t.Name == inputArgs[1]);
                if (currentTeam == null)
                {
                    Console.WriteLine($"Team {inputArgs[1]} does not exist.");
                    continue;
                }
                if (inputArgs[0] == "Add")
                {

                    try
                    {
                        var currentPlayerStats = inputArgs.Skip(3).Select(int.Parse).ToArray();
                        currentTeam.AddPlayer(new Player(inputArgs[2], currentPlayerStats));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (inputArgs[0] == "Remove")
                {
                    try
                    {
                        currentTeam.RemovePlayer(inputArgs[2]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (inputArgs[0] == "Rating")
                {
                    Console.WriteLine($"{currentTeam.Name} - {currentTeam.GetRating()}");

                }
            }
        }

    }
}
