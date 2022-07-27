
/*
    Decorator desing pattern attaches additional responsibilities to an object dynamically.
    This pattern pvoides a flexible alternative to subclassing for extending functionality.

    Participants
        Component          : defines the interface for objects that can have responsibilities added to them dynamically
        Concrete Component : defines an object to which additional responsibilities can be attached
        Decorator          : maintains a reference to a Component object and defines an interface that conforms to Components interface
        Concrete Decorator : adds responsibilities to the component
 */

using Decorator.Components;
using Decorator.Decorators;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            Video video = new Video("Spielberg", "Jaws", 92, 21);
            video.Display();

            Console.WriteLine("making video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            Console.ReadKey();
        }
    }
}