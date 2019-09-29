using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm,double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            
        }

        protected virtual double FuelQuantity { get; set; }

        protected double FuelConsumptionPerKm { get; set; }

        protected virtual double TankCapacity { get; set; }

        protected virtual bool Drive(double kmToDrive,bool emptyOrNot)
        {
            var fuelRequired = kmToDrive * this.FuelConsumptionPerKm;
            if (fuelRequired <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelRequired;
                return true;
            }

            return false;
        }

        public string TryTravelDistance(double distance,bool emptyOrNot)
        {
            if (this.Drive(distance,emptyOrNot))
            {
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public string TryTravelDistance(double distance)
        {
            return this.TryTravelDistance(distance, true);
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += liters;
        }


        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
