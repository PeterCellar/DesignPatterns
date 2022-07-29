
/*
    State design pattern allows an object to alter its behavior when its internal state
    changes. The object will appear to change its class.

    Participants
        Context        : defines the interface of interest to clients, maintains an instance of a 
                         Concrete State subclass that defines the current state
        State          : defines an interface for encapsulating the behavior associated with a particular state of the Context
        Concrete State : each subclass implements a behavior associated with a state of Context 
 */

namespace State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account("Jim Johnson");

            account.Deposit(500.0);
            account.Deposit(1500.0);
            account.PayInterest();
            account.Withdraw(1000.0);
            account.Withdraw(1500.0);
            account.Withdraw(780.0);

            Console.ReadKey();
        }
    }
}