
using Facade.Subsystems;

namespace Facade
{
    // The facade class
    public class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", customer.Name, amount);

            bool eligible = true;

            if (!bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }else if (!credit.HasGoodCredit(customer, amount))
            {
                eligible=false;
            }

            return eligible;
        }
    }
}
