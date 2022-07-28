
/*
    Mediator design pattern defines an object that encapsulates how a set of objects interact.
    Mediator promotes loose coupling by keeping objects from referring to each other explicitly,
    and it lets you vary their interaction independently.

    Participants
        Mediator           : defines an interface for communicating with Colleague objects
        Concrete Mediator  : implements cooperative behavior by coordinating Colleague objects
                             knows and maintains its colleagues
        Colleagues classes : each Colleague class knows its Mediator object
                             each colleagye communicates with its mediator whenever it would have 
                             communicate with another colleague
 */

using Mediator.Colleagues;

namespace Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chatroom chatroom = new Chatroom();

            Participant George = new Beatle("George");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            Yoko.Send("John", "Hi John!");
            John.Send("Yoko", "My sweet love");


            Console.ReadKey();
        }
    }
}