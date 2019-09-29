using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double consumptionPerKm;
        private double totalDistance = 0;
        public double ConsumptionPerKm
        {
            get { return this.consumptionPerKm; }
            set { this.consumptionPerKm = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double TotalDistance
        {
            get { return this.totalDistance; }
            set { this.totalDistance = value; }
        }
        public Car(string model, int fuelAmount, double consumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.ConsumptionPerKm = consumptionPerKm;
            
        }

        public double MaxDistance()
        {
            return this.FuelAmount / this.ConsumptionPerKm;
        }

        public void CanItRun(double kmToRun)
        {
            if (kmToRun > MaxDistance())
            {
                throw new ArgumentException("Insufficient fuel for the drive");
            }
            this.FuelAmount -= kmToRun * this.ConsumptionPerKm;
            this.totalDistance += kmToRun;
        }
    }
}
