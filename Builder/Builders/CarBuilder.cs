using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "2000 cc";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Car frame";
        }
    }
}
