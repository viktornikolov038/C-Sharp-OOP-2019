using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Vehicles
{
    public class Program
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            var busInfo = Console.ReadLine().Split(' ');
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var typeVehicle = command[1];
                    if (typeVehicle == "Car")
                    {
                        ExecuteAction(car, command[0], double.Parse(command[2]));
                    }
                    else if (typeVehicle == "Truck")
                    {
                        ExecuteAction(truck, command[0], double.Parse(command[2]));
                    }
                    else if (typeVehicle == "Bus")
                    {
                        ExecuteAction(bus, command[0], double.Parse(command[2]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }



            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
        {
            switch (command)
            {
                case "Drive":
                    var result = vehicle.TryTravelDistance(parameter);
                    Console.WriteLine(result);
                    break;
                case "Refuel":
                    vehicle.Refuel(parameter);
                    break;
                case "DriveEmpty":
                    Console.WriteLine(vehicle.TryTravelDistance(parameter, false));
                    break;
            }
        }
    }
}
