
/*
    Observer design pattern defines a one-to-many dependency between objects so that when
    one object changes state, all it dependents are notified and updated automatically

    Participants
        Subject           : knows its observers, provides an interface for attaching and detaching Observer objects
        Concrete Subject  : stores state of interest to Concrete Observer
        Observer          : defines an updating interface for objects that should be notified of changes in a subject
        Concrete Observer : maintains a reference to a Concrete Subject object, stores state that should stay witch subjects
                            implements the Observer updating interface to keep its state consistent witch subject
 */

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            ibm.Price = 120.10;
            ibm.Price = 120.50;
            ibm.Price = 121.00;
            ibm.Price = 120.66;

            Console.ReadKey();
        }
    }
}