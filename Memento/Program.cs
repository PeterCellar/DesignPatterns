
/*
    Memento design pattern without violating encapsulation, captures and externalizes
    an objects internal state so that the object can be restored to this state later.

    Participants
        Memento    : stores internal state of the Originator object. Protects against access
                     by objects of other than the originator
        Originator : creates a memento containing a snapshot of its current internal state
                     uses the memento to restore its internal state
        Caretaker  : is responsible for the mementos sagekeeping, never operates on or examines
                     the contents of a memento
 */

namespace Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            s.RestoreMemento(m.Memento);

            Console.ReadKey();
        }
    }
}