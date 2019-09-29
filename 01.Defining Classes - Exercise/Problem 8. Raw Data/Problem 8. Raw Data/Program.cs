using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Raw_Data
{
    public class Program
    {
        public static void Main()
        {
            var carNumber = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < carNumber; i++)
            {
                var carArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var model = carArgs[0];
                var engineSpeed = int.Parse(carArgs[1]);
                var enginePower = int.Parse(carArgs[2]);
                var cargoWeight = int.Parse(carArgs[3]);
                var cargoType = carArgs[4];
                var t1p = double.Parse(carArgs[5]);
                var t1age = int.Parse(carArgs[6]);
                var t2p = double.Parse(carArgs[7]);
                var t2age = int.Parse(carArgs[8]);
                var t3p = double.Parse(carArgs[9]);
                var t3age = int.Parse(carArgs[10]); 
                var t4p = double.Parse(carArgs[11]);
                var t4age = int.Parse(carArgs[12]);

                cars.Add(new Car(model,
                    new Engine(engineSpeed,enginePower),
                    new Cargo(cargoWeight,cargoType),
                    new Tires(t1p,t1age,t2p,t2age,t3p,t3age,t4p,t4age)));
            }
            var command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var car in cars.Where(c =>
                        c.Cargo.CargoType == "fragile" &&
                        (c.Tires.Tire1Pressure < 1 || c.Tires.Tire2Pressure < 1 || c.Tires.Tire3Pressure < 1 ||
                         c.Tires.Tire4Pressure < 1))
                    .ToArray())
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250).ToArray())
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
