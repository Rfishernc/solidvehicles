using System;
using solidvehicles;

public class SinglePropAirplane : IVehicle, IFlyingVehicle, ILandVehicle
{
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "Fixed-geared";
    public double EngineVolume { get; set; }
    public double MaxAirSpeed { get; set; }
    public double MaxLandSpeed { get; set; }

    public SinglePropAirplane(int doors, int passengerCapacity, bool winged, double engineVolume, double maxAirSpeed, double maxLandSpeed)
    {
        Doors = doors;
        PassengerCapacity = passengerCapacity;
        Winged = winged;
        EngineVolume = engineVolume;
        MaxAirSpeed = maxAirSpeed;
        MaxLandSpeed = maxLandSpeed;
    }

    public void Drive()
    {
        Console.WriteLine("The airplane drives down the runway.");
    }

    public void Fly()
    {
        Console.WriteLine("The airplane effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        Console.WriteLine("The airplane starts");
    }

    public void Stop()
    {
        Console.WriteLine("The airplane stops");
    }
}
