using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Pizza_Calories
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value[0].ToString().ToUpper()}{string.Join("",value.Skip(1))} on top of your pizza.");
                }
                this.type = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type[0].ToString().ToUpper()}{string.Join("", this.type.Skip(1))} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public double GetToppingCalories()
        {
            switch (this.Type)
            {
                case "meat":
                    return 2 * this.Weight * 1.2;
                    break;
                case "veggies":
                    return 2 * this.Weight * 0.8;
                    break;
                case "cheese":
                    return 2 * this.Weight * 1.1;
                    break;
                case "sauce":
                    return 2 * this.Weight * 0.9;
                    break;
            }
            return 0;
        }
    }
}
