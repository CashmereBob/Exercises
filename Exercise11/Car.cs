using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Car : Vehicle
    {
        private bool engineIsRunning = false;
        public Car() : base ("Car")
        {
            
        }
        public override string DescribeVehicle()
        {
            var engineStatus = this.engineIsRunning ? "is running" : "is not running";
            return "This vehicle is a " + _vehicleType + " and the engine " + engineStatus;
        }
        public void StartEngine()
        { this.engineIsRunning = true; }

        public void StopEngine()
        { this.engineIsRunning = false; }
    }
}
