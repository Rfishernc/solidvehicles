using System;
using solidvehicles;

public class JetSki : IVehicle, IWaterVehicle
{
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public JetSki(int passengerCapacity, string transmissionType, double engineVolume, double maxWaterSpeed)
    {
        PassengerCapacity = passengerCapacity;
        TransmissionType = transmissionType;
        EngineVolume = engineVolume;
        MaxWaterSpeed = maxWaterSpeed;
    }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        Console.WriteLine("The jetski starts");
    }
    public void Stop()
    {
        Console.WriteLine("The jetski stops");
    }
}
