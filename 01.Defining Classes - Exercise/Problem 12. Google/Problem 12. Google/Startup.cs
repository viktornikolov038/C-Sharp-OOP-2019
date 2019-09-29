using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Google
{
    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                var inputArgs = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var name = inputArgs[0];
                var alreadyExist = people.FirstOrDefault(p => p.Name == name);
                if (alreadyExist == null)
                {
                    people.Add(new Person(name));
                }

                var currentPerson = people.First(p => p.Name == name);
                var infAbout = inputArgs[1];
                switch (infAbout)
                {
                    case "company":
                        currentPerson.Company = new Company(inputArgs[2],inputArgs[3],decimal.Parse(inputArgs[4]));
                        break;
                    case "pokemon":
                        currentPerson.Pokemons.Add(new Pokemon(inputArgs[2],inputArgs[3]));
                        break;
                    case "parents":
                        var birthDateParent = DateTime.ParseExact(inputArgs[3], "dd/MM/yyyy", CultureInfo.CurrentCulture);
                        currentPerson.Parents.Add(new Parent(inputArgs[2],birthDateParent));
                        break;
                    case "children":
                        var birthDateChild = DateTime.ParseExact(inputArgs[3], "dd/MM/yyyy", CultureInfo.CurrentCulture);
                        currentPerson.Children.Add(new Child(inputArgs[2],birthDateChild));
                        break;
                    case "car":
                        currentPerson.Car = new Car(inputArgs[2],int.Parse(inputArgs[3]));
                        break;
                    default:
                        break;
                }
            }
            var nameToPrint = Console.ReadLine();
            Console.WriteLine(people.FirstOrDefault(p => p.Name == nameToPrint).ToString());
            
        }
    }
}
