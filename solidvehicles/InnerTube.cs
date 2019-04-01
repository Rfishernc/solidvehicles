using System;
using System.Collections.Generic;
using System.Text;

namespace solidvehicles
{
    public class InnerTube : IVehicle, IWaterVehicle
    {
        public double MaxWaterSpeed { get; set; } = 40;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 1;
        public string TransmissionType { get; set; } = "none";
        public double EngineVolume { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("The innertube floats along on its own terms.");
        }

        public void Start()
        {
            Console.WriteLine("The innertube starts floating along.");
        }

        public void Stop()
        {
            Console.WriteLine("The innertube stops.");
        }
    }
}
