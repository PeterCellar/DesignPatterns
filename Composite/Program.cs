
/*
    Composite design pattern composes objects into tree structures to represent
    part-whole hierarchies. This pattern lets clients treat individual objects and compositions 
    of objects uniformly.

    Participants
        Component : declares the interface for objects in the composition
                  : implements default behavior for the interface common to all classes, as appropriate.
                  : declares an interface for accessing and managing its child components
        Leaf      : represents leaf objects in the composition. Defines behavior for primitive objects in the composition
        Composite : defines behavior for components having children, stores child components
                  : implements child-related operations in the Component interface
        Client    : manipulates objects in the composition through the Component interface.
 */

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Display(1);

            root.Remove(leaf);

            root.Display(1);
            

            Console.ReadKey();
        }
    }
}