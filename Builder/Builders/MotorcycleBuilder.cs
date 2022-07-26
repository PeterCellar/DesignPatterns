
namespace Builder.Builders
{
    class MotorcycleBuilder : VehicleBuilder
    {
        public MotorcycleBuilder()
        {
            vehicle = new Vehicle("Motorcycle");
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Motorcycle Frame";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "750 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
    }
}
