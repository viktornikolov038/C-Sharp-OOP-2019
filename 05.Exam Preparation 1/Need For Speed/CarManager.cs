using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


public class CarManager
{

    public static Dictionary<int, Car> allCars = new Dictionary<int, Car>();
    public static Dictionary<int, Race> allRaces = new Dictionary<int, Race>();

    public static void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        if (type == "Performance")
        {
            var performanceCar = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability, 0, false, false);
            allCars.Add(id, performanceCar);
        }
        else
        {
            var showCar = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability, 0, false, false);
            allCars.Add(id, showCar);
        }
    }

    public static string Check(int id)
    {
        var car = allCars[id];
        return car.ToString();
    }

    public static void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                var casualRace = new CasualRace(length, route, prizePool, new List<Car>(), type);
                allRaces.Add(id, casualRace);
                break;
            case "Drag":
                var dragRace = new DragRace(length, route, prizePool, new List<Car>(), type);
                allRaces.Add(id, dragRace);
                break;
            case "Drift":
                var driftRace = new DriftRace(length, route, prizePool, new List<Car>(), type);
                allRaces.Add(id, driftRace);
                break;

        }
    }

    public static void Participate(int carId, int raceId)
    {
        if (allCars[carId].IsParked == false)
        {
            allCars[carId].IsInRace = true;
            allRaces[raceId].AddCarsToRace(allCars[carId]);
        }

    }

    public static string Start(int id)
    {
        var result = new List<Car>();
        var raceType = allRaces[id].Type;
        var currentRace = allRaces[id];
        if (currentRace.Participants.Count <= 0)
        {
            throw new ArgumentException("Cannot start the race with zero participants.");
        }
        switch (raceType)
        {
            case "Casual":
                foreach (Car car in currentRace.Participants)
                {
                    var op = 0;
                    op = (car.HorsePower / car.Acceleration) + (car.Suspension + car.Durability);
                    car.PerformancePoints = op;
                    car.IsInRace = false;
                    result.Add(car);
                }
                break;
            case "Drag":
                foreach (Car car in currentRace.Participants)
                {
                    var ep = 0;
                    ep = car.HorsePower / car.Acceleration;
                    car.PerformancePoints = ep;
                    car.IsInRace = false;
                    result.Add(car);
                }
                break;
            case "Drift":
                foreach (Car car in currentRace.Participants)
                {
                    var sp = 0;
                    sp = car.Suspension + car.Durability;
                    car.PerformancePoints = sp;
                    car.IsInRace = false;
                    result.Add(car);
                }
                break;

        }
        result.OrderByDescending(c => c.PerformancePoints);
        var sb = new StringBuilder();
        sb.AppendLine($"{allRaces[id].Route} - {allRaces[id].Length}");

        if (result.Count >= 3)
        {
            sb.AppendLine(
                $"1. {result[0].Brand} {result[0].Brand} {result[0].PerformancePoints}PP - ${currentRace.PrizePool * 0.5}");
            sb.AppendLine(
                $"2. {result[1].Brand} {result[1].Brand} {result[1].PerformancePoints}PP - ${currentRace.PrizePool * 0.3}");
            sb.Append(
                $"3. {result[2].Brand} {result[2].Brand} {result[2].PerformancePoints}PP - ${currentRace.PrizePool * 0.2}");
        }
        else if(result.Count == 2)
        {
            sb.AppendLine(
                $"1. {result[0].Brand} {result[0].Brand} {result[0].PerformancePoints}PP - ${currentRace.PrizePool * 0.5}");
            sb.AppendLine(
                $"2. {result[1].Brand} {result[1].Brand} {result[1].PerformancePoints}PP - ${currentRace.PrizePool * 0.3}");
        }
        else
        {
            sb.AppendLine(
                $"1. {result[0].Brand} {result[0].Brand} {result[0].PerformancePoints}PP - ${currentRace.PrizePool * 0.5}");
        }
        return sb.ToString().TrimEnd();
    }




    public static void Park(int id)
    {
        if (allCars[id].IsInRace == false)
        {
            allCars[id].IsParked = true;
            Garage.ParkCar(allCars[id]);
        }
    }

    public static void Unpark(int id)
    {
        allCars[id].IsParked = false;
        Garage.UnParkCar(allCars[id]);
    }

    public static void Tune(int tuneIndex, string addOn)
    {
        foreach (Car car in Garage.parkedCars)
        {
            car.Tune(tuneIndex,addOn);
        }
    }




}

