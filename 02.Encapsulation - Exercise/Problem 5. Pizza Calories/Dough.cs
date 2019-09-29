using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Pizza_Calories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
            
        }
        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }
        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }


        public double GetCalories()
        {
            switch (this.flourType)
            {
                case "white":
                    switch (this.BakingTechnique)
                    {
                        case "crispy":
                            return 2 * this.Weight * 1.5 * 0.9;
                            break;
                        case "chewy":
                            return 2 * this.Weight * 1.5 * 1.1;
                            break;
                        case "homemade":
                            return 2 * this.Weight * 1.5 * 1.0;
                            break;
                    }
                    break;
                case "wholegrain":
                    switch (this.BakingTechnique)
                    {
                        case "crispy":
                            return 2 * this.Weight * 1.0 * 0.9;
                            break;
                        case "chewy":
                            return 2 * this.Weight * 1.0 * 1.1;
                            break;
                        case "homemade":
                            return 2 * this.Weight * 1.0 * 1.0;
                            break;
                    }
                    break;
            }
            return 0;
        }
    }
}
