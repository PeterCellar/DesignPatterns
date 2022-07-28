
/*
    Facade design pattern provide a unified interface to a set of interfaces in a subsystem.
    Pattern defines a higher-level interface that makes the subsystem easier to use.

    Participants
        Facade            : knows which subsystem classes are responsible for a request
                            delegates client requests to appropriate subsystem objects
        Subsystem classes : implements subsystem functionality
                            handle work assigned by the Facade object
                            have knowledge of the facade and keep no reference to it
 */

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 10000);

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            Console.ReadKey();
        }
    }
}