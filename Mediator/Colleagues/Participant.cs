
namespace Mediator.Colleagues
{
    public abstract class Participant
    {
        Chatroom chatroom;
        string name;

        public Participant(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public Chatroom Chatroom
        {
            get { return chatroom; }
            set { chatroom = value; }
        }

        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}
