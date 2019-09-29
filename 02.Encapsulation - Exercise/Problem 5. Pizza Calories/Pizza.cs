using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private int numberOfToppings;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
            this.NumberOfToppings = numberOfToppings;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public int NumberOfToppings
        {
            get { return this.numberOfToppings; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.numberOfToppings = value;
            }
        }

        public void AddToppings(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public void AddDough(Dough dough)
        {
            this.dough = dough;
        }
        public double GetCalories()
        {
            var toppingsSum = 0.0;
            foreach (var topping in toppings)
            {
                toppingsSum += topping.GetToppingCalories();
            }
            toppingsSum += dough.GetCalories();
            return toppingsSum;
        }
    }
}
