using System.Collections.Generic;
using System.Text;

namespace Problem_12.Google
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }
        public string Name { get; set; }
        public Company Company { get; set; }
        public Car Car { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Child> Children { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine($"Company:");
            if (this.Company != null) sb.AppendLine(this.Company.ToString());
            sb.AppendLine($"Car:");
            if (this.Car != null) sb.AppendLine(this.Car.ToString());
            sb.AppendLine($"Pokemon:");
            if (this.Pokemons != null)
            {
                foreach (var pokemon in this.Pokemons)
                {
                    sb.AppendLine(pokemon.ToString());
                }
            }
            sb.AppendLine("Parents:");
            if (this.Parents != null)
            {
                foreach (var parent in this.Parents)
                {
                    sb.AppendLine(parent.ToString());
                }
            }
            sb.AppendLine("Children:");
            if (this.Children != null)
            {
                foreach (var child in this.Children)
                {
                    sb.AppendLine(child.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
