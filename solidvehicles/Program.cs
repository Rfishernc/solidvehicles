using System;
using System.Linq;
using System.Collections.Generic;
using solidvehicles;

public class Program
{
    public static void Main()
    {
        var harley = new Motorcycle(2, "manual", 88, 180);
        var pinto = new Car(100, 4, 5, "manual", 1.8);
        var apache = new Helicopter(182, 1, 2, 2000);
        var cessna = new SinglePropAirplane(2, 3, true, 160, 140, 70);
        var seado = new JetSki(2, "automatic", 1.2, 68);
        var someOldTube = new InnerTube();

        List<ILandVehicle> LandVehicles = new List<ILandVehicle>() { harley, pinto, cessna};
        List<IFlyingVehicle> FlyingVehicles = new List<IFlyingVehicle>() { apache, cessna};
        List<IWaterVehicle> WaterVehicles = new List<IWaterVehicle>() { seado, someOldTube};

        foreach(ILandVehicle vehicle in LandVehicles)
        {
            vehicle.Drive();
        }

        foreach(IFlyingVehicle vehicle in FlyingVehicles)
        {
            vehicle.Fly();
        }

        foreach (IWaterVehicle vehicle in WaterVehicles)
        {
            vehicle.Drive();
        }

        // Build a collection of all vehicles that fly

        // With a single `foreach`, have each vehicle Fly()


        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()
        Console.ReadLine();
    }
}