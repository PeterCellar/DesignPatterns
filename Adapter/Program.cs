
/*
    Adapter design pattern converts the interface of a class into
    another interface clients expect. The design pattern lets classes
    work together that couldnt otherwise beacause of incompatible interfaces.

    Participants
        Target  : defines the domain-specific interface that client uses
        Adapter : adapts the interface Adaptee to the Target interface
        Adaptee : defines an existing interface that needs adapting
        Client  : collaborates with objects conforming to the Target interface
 */

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound();
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            Console.ReadKey();
        }
    }
}