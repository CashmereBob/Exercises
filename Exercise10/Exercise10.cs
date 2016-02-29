using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            VehicleData _vehicleData = new VehicleData();
            Car _car = new Car();
            Boat _boat = new Boat();

            _vehicleData.PrintVehicle(_car);
            _vehicleData.PrintVehicle(_boat);

            Console.ReadKey();
        }
    }
}
