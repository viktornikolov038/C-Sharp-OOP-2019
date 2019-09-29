using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    //public static Dictionary<int, Car> allCars = new Dictionary<int, Car>();
    //public static Dictionary<int, Race> allRaces = new Dictionary<int, Race>();

    public static void Main()
    {
        //var allCars = new Dictionary<int,Car>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "Cops Are Here")
            {
                break;
            }
            var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var command = tokens[0];
            try
            {
                switch (command)
                {
                    case "register":
                        Register(tokens);
                        break;
                    case "check":
                        Check(tokens[1]);
                        break;
                    case "open":
                        Open(tokens);
                        break;
                    case "participate":
                        var carId = int.Parse(tokens[1]);
                        var raceId = int.Parse(tokens[2]);
                        CarManager.Participate(carId,raceId);
                        break;
                    case "start":
                        var currentRaceId = int.Parse(tokens[1]);
                        Console.WriteLine(CarManager.Start(currentRaceId));
                        break;
                    case "park":
                        var parkId = int.Parse(tokens[1]);
                        ParkCar(parkId);
                        break;
                    case "unpark":
                        var unparkId = int.Parse(tokens[1]);
                        UnParkCar(unparkId);
                        break;
                    case "tune":
                        var tuneIndex = int.Parse(tokens[1]);
                        var tuneAddOn = tokens[2];
                        CarManager.Tune(tuneIndex,tuneAddOn);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }


    }

    private static void UnParkCar(int unparkId)
    {
        CarManager.Unpark(unparkId);
    }

    private static void ParkCar(int parkId)
    {
        CarManager.Park(parkId);
    }


    private static void Open(string[] tokens)
    {
        var id = int.Parse(tokens[1]);
        var type = tokens[2];
        var length = int.Parse(tokens[3]);
        var route = tokens[4];
        var prizePool = int.Parse(tokens[5]);
        CarManager.Open(id,type,length,route,prizePool);
    }

    private static void Check(string idAsString)
    {
        var id = int.Parse(idAsString);
        Console.WriteLine(CarManager.Check(id));
        
    }

    private static void Register(string[] tokens)
    {
        var id = int.Parse(tokens[1]);
        var type = tokens[2];
        var brand = tokens[3];
        var model = tokens[4];
        var year = int.Parse(tokens[5]);
        var horsepower = int.Parse(tokens[6]);
        var acceleration = int.Parse(tokens[7]);
        var suspension = int.Parse(tokens[8]);
        var durability = int.Parse(tokens[9]);

        CarManager.Register(id, type, brand, model, year, horsepower, acceleration, suspension, durability);
    }
}
