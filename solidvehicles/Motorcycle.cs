using System;
using solidvehicles;

public class Motorcycle : IVehicle, ILandVehicle
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxLandSpeed { get; set; }

    public Motorcycle(int passengerCapacity, string transmissionType, double engineVolume, double maxLandSpeed)
    {
        PassengerCapacity = passengerCapacity;
        TransmissionType = transmissionType;
        EngineVolume = engineVolume;
        MaxLandSpeed = maxLandSpeed;
    }

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        Console.WriteLine("The motorcycle starts");
    }

    public void Stop()
    {
        Console.WriteLine("The motorcycle stops");
    }
}
