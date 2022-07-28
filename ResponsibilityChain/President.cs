
namespace ResponsibilityChain
{
    public class President : Approver
    {
        public override void ProcessRequest(Purchase request)
        {
            if (request.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request #{1}", this.GetType().Name, request.Number);
            }
            else 
            {
                Console.WriteLine(
                    "Request #{0} requires an executive meeting!",
                    request.Number);
            }
        }
    }
}
