
/*
    Command design pattern encapsulates a request as an object, thereby letting you
    parametrize clients with different requests, queue or log requests, and support undoable operations.

    Participants
        Command          : declares an interface for executing an operation
        Concrete Command : defines a binding between a Reciever object and an action
                           implements Execute by invoking the corresponding operations on Reciever
        Client           : creates a Concrete Command object and sets its reciever
        Invoker          : asks the command to carry out the request
        Reciever         : knows how to perform the operations associated with carrying out the request
 */

namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);
            user.Redo(3);

            Console.ReadKey();
        }
    }
}