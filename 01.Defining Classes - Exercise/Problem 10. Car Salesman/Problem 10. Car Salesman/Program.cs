using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Car_Salesman
{
    public class Program
    {
        public static void Main()
        {
            var numOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            var cars = new List<Car>();
            for (int i = 0; i < numOfEngines; i++)
            {
                var currentEngineInput = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var currentEngine = new Engine(currentEngineInput[0], int.Parse(currentEngineInput[1]));
                if (currentEngineInput.Length >= 3 &&  int.TryParse(currentEngineInput[2],out var displacement))
                {
                    currentEngine.Displacement = displacement;
                }
                else if(currentEngineInput.Length >= 3)
                {
                    currentEngine.Efficiency = currentEngineInput[2];
                }

                if (currentEngineInput.Length == 4)
                {
                    currentEngine.Efficiency = currentEngineInput[3];
                }

                engines.Add(currentEngine);
            }

            var numOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCars; i++)
            {
                var currentCarInput = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var currentCar = new Car(currentCarInput[0],engines.Find(e => e.Model == currentCarInput[1]));
                if (currentCarInput.Length >= 3 && int.TryParse(currentCarInput[2],out var weight))
                {
                    currentCar.Weight = weight;
                }
                else if(currentCarInput.Length >= 3)
                {
                    currentCar.Color = currentCarInput[2];
                }
                if (currentCarInput.Length == 4)
                {
                    currentCar.Color = currentCarInput[3];
                }

                cars.Add(currentCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString().TrimEnd());
            }
        }
    }
}
