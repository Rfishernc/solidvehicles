using System;
using System.Collections.Generic;
using System.Text;

namespace solidvehicles
{
    public class Helicopter : IVehicle, IFlyingVehicle
    {
        public bool Winged { get; set; } = false;
        public double MaxAirSpeed { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "fixed-geared";
        public double EngineVolume { get; set; }

        public Helicopter(double maxAirSpeed, int doors, int passengerCapacity, double engineVolume)
        {
            MaxAirSpeed = maxAirSpeed;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
        }

        public void Fly()
        {
            Console.WriteLine("The helicopter flys about.");
        }

        public void Start()
        {
            Console.WriteLine("The helicopter starts.");
        }

        public void Stop()
        {
            Console.WriteLine("The helicopter stops.");
        }
    }
}
