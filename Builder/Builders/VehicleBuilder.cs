
namespace Builder.Builders
{
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        // Get vehicle instance
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();

    }
}
