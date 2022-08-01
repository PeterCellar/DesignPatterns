/*
    Visitor design pattern represents an operation to be performed on the elements
    of an object structure. This pattern lets you define a new operation without changing
    the classes of the elemnts on which it operates.

    Participants
        Visitor           : declares a Visit operation for each class of ConcreteElement in the object
                            structure. The operations name and signature identifies the class that sends
                            the Visit request to the visitor. That lets the visitor determine the concrete
                            class of the element being visited. Then the visitor can access the elements
                            directly through its particular interface.
        
        Concerete Visitor : implements each operation declared by Visitor. Each operation implements a fragment
                            of the algorithm defined for the corresponding class or object in the structure. 
                            Concrete Visitor provides the context for the algorithm and stores its local state.
                            This state often accumulates results during the traversal of the structure.
        
        Elemnt            : defines an Accept operation that takes a visitor as an argument
 
        Concrete Elemnt   : implements an Accept operation that takes a visitor as an argument

        Object Structure  : can enumerate its elements, may provide a high-level interface to allow the visitor
                             to visit its elements. May either be a Composite(pattern) or a collection such as a list or set
 */
using Visitor.Employment;
using Visitor.Visitors;

namespace Visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employees employees = new Employees();
            employees.Attach(new Clerk());
            employees.Attach(new Director());
            employees.Attach(new President());

            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());
            Console.ReadKey();
        }
    }
}