
namespace ResponsibilityChain
{
    public class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase request)
        {
            if (request.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request #{1}", this.GetType().Name, request.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(request);
            }
        }
    }
}
