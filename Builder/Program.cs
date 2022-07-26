
/*
    Builder design pattern separates the construction of a complex object 
    from its representation so that the same construction process
    can create different represenations.

    Participants
        Builder          : specifies an abstract interface for creating parts of a Product object
        Concrete Builder : constructs and assembles parts of the product by implementing the Builder interface
                         : defines and keeps track of the representation it creates
                         : provides an interface for retrieving the product
        Director         : constructs an object using the Builder interface
        Product          : represents the complex object under construction
                         : includes classes that define the constituent parts, including interfaces for assembling the parts into the final result
 */
using Builder;
using Builder.Builders;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VehicleBuilder builder;

            // Shop with vehicle builders
            Shop shop = new Shop();

            // Construction of Scooter vehicle
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Construction of Car vehicle
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Construction of Motorcycle vehicle
            builder = new MotorcycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }
    }
}