
/*
    Bridge design pattern decouples an abstraction from its implementation
    so that the two can vary independently.

    Participants
        Abstraction          : defines the abstractions interface
                               maintains a reference to an object of type Implementor
        Refined Abstraction  : extends the interface defined by Abstraction
        Implementor          : defines the interface for implementation classes
        Concrete Implementor : implements the Implementor interface and defines its concrete implementation 
 
 */

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create RefinedAbstraction
            var customers = new Customers();

            // Set ConcreteImplementor
            customers.Data = new CostumerData("Chicago");

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            Console.ReadKey();
        }
    }
}