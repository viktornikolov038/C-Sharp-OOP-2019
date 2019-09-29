using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Speed_Racing
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var allCars = new Dictionary<string, Car>();
            AddCars(n, allCars);
            StartDriving(allCars);
            PrintCarsInTheEnd(allCars);
        }

        private static void PrintCarsInTheEnd(Dictionary<string, Car> allCars)
        {
            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:f2} {car.Value.TotalDistance}");
            }
        }

        private static void StartDriving(Dictionary<string, Car> allCars)
        {
            while (true)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                var model = input[1];
                var kmToRun = double.Parse(input[2]);
                try
                {
                    allCars[model].CanItRun(kmToRun);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }

        private static void AddCars(int n, Dictionary<string, Car> allCars)
        {
            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = carInfo[0];
                var fuelAmount = int.Parse(carInfo[1]);
                var consumptionPerKm = double.Parse(carInfo[2]);
                var car = new Car(model, fuelAmount, consumptionPerKm);
                allCars.Add(model, car);
            }
        }
    }
}
