
namespace Mediator.Colleagues
{
    public class Beatle : Participant
    {
        public Beatle(string name)
            : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
