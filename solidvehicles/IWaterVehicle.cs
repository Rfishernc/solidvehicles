using System;
using System.Collections.Generic;
using System.Text;

namespace solidvehicles
{
    public interface IWaterVehicle
    {
        double MaxWaterSpeed { get; set; }
        void Drive();
    }
}
