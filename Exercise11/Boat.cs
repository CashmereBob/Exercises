using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Boat : Vehicle
    {
        private bool sailIsUpp = true;
        public Boat() : base ("Boat")
        {

        }

        public override string DescribeVehicle()
        {
            var sailStatus = this.sailIsUpp ? "is set" : "is not set";
            return "This vehicle is a " + _vehicleType + " and the sail " + sailStatus;
        }
        public void SetSail()
        { this.sailIsUpp = true; }

        public void BringDownSail()
        { this.sailIsUpp = false; }
    }
}
