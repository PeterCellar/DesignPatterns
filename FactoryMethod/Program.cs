
/*
    Factory Method design pattern defines an interface for creating an object, 
    but let subclasses decide which class to instantiate. This pattern lets
    a class defet instantiation to subclasses.

    Participants
        Product          : defines the interface of objects the factory method creates
        Concrete Product : implements the Product interface
        Creator          : declares the factory method, which returns an object of type Product
                         : may call the factory method to create a Product object
        Concrete Creator : overrides the factory method to return an instance of a Concrete Product
 */

using FactoryMethod.Documents;
using FactoryMethod.Pages;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach(Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach( Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}