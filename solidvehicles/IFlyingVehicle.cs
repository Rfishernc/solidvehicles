using System;
using System.Collections.Generic;
using System.Text;

namespace solidvehicles
{
    public interface IFlyingVehicle
    {
        bool Winged { get; set; }
        double MaxAirSpeed { get; set; }
        void Fly();
    }
}
