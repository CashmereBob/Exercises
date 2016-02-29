using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Boat : Vehicle
    {
        private bool engineIsRunning = false;
        public Boat() : base ("Boat")
        {

        }

        public void StartEngine()
        { this.engineIsRunning = true; }

        public void StopEngine()
        { this.engineIsRunning = false; }
    }
}
