using System;
using System.Collections.Generic;
using System.Text;

namespace solidvehicles
{
    public interface ILandVehicle
    {
        int Wheels { get; set; }
        double MaxLandSpeed { get; set; }
        void Drive();
    }
}
