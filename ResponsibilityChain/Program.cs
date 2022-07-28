
/*
    Chain of Responsibility design pattern avoids coupling the sender of a request to its
    reciever by giving more than one object a chance to handle the request. This pattern chains 
    the recieving objects and passes the request along the chain until an object handles it.

    Participants
        Handler          : defines an interface for handling the requests. (Optional) implements the successor link
        Concrete Handler : handles requests it is responsible for, can access its successor
                           if the concrete handler can handle the request, it does so; otherwise it forwards the request to its successsor
        Client           : initiates the request to a concrete handler object on the chain
 */

namespace ResponsibilityChain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Chain of responsibility
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            Purchase purchase = new Purchase(20, 3250.00, "Supplies");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(250, 15789.26, "Monitors");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(115, 565020.00, "Cars");
            larry.ProcessRequest(purchase);
           
            Console.ReadKey();
        }
    }
}