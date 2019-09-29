using System;

namespace Problem_12.Google
{
    public class Child
    {
        public Child(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}";
        }
    }
}