
namespace Facade.Subsystems
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            if (amount > 3000)
            {
                Console.WriteLine(c.Name + " has sufficient savings");
                return true;
            }
            else
            {
                Console.WriteLine(c.Name + " doesnt have sufficinet savings");
                return false;
            }
        }
    }
}
