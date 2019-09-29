using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Vehicles
{
    class Bus : Vehicle
    {
        private const double AcConsumptionMod = 1.4;
        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm,tankCapacity)
        {
        }

        protected override double FuelQuantity
        {
            set
            {
                if (this.TankCapacity < value)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }
                base.FuelQuantity = value;
            }
        }

        protected override bool Drive(double kmToDrive,bool emptyOrNot)
        {
            var requiredFuel = 0.0;
            if (emptyOrNot)
            {
                requiredFuel = kmToDrive * (this.FuelConsumptionPerKm + AcConsumptionMod);
            }
            else
            {
                requiredFuel = kmToDrive * this.FuelConsumptionPerKm ;
            }

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return true;
            }
            return false;
        }
    }
}
