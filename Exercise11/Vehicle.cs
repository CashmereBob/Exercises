using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    abstract class Vehicle
    {
        public string _vehicleType = string.Empty;

        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        public virtual string DescribeVehicle()
        {
            return "This vehicle is a " + _vehicleType;
        }
    }
}
