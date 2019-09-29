using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Garage
{
    public static List<Car> parkedCars = new List<Car>();

    public static void ParkCar(Car car)
    {
        parkedCars.Add(car);
    }

    public static void UnParkCar(Car car)
    {
        parkedCars.Remove(car);
    }

    
}

