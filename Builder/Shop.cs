using Builder.Builders;

namespace Builder
{
    // Director class
    class Shop
    {
        public void Construct(VehicleBuilder builder)
        {
            builder.BuildWheels();
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildDoors();
        }
    }
}
