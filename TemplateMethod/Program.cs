/*
    Template Method design pattern defines the skeleton of an algorithm in an operation,
    deferring some steps to subclasses. This pattern lets subclasses redefine certain steps
    of an algorithm without changing the algorithms structure.

    Participants
        AbstractClass : defines abstract primitive operations that concrete subclasses define
                        to implement steps of an algorithm. Implements a template method defining
                        the skeleton of an algorithm. The template method calls primitive operations
                        as well as operations defines in AbstractClass or those of other objects.
        ConcreteClass : implements the primitive operations to carry out subclass-specifig steps of the algorithm
 */

namespace TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataAccessor categories = new Categories();
            categories.Run(5);

            DataAccessor products = new Products();
            products.Run(3);

            Console.ReadKey();
        }
    }
}