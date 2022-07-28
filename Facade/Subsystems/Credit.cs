
namespace Facade.Subsystems
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c, int credit)
        {
            Console.WriteLine("Credit of client " + c.Name + " is " + credit);
            return true;
        }
    }
}
