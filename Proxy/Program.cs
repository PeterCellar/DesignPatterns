
/*
    Proxy design pattern provides a surrogate or placeholder for another object to control access to it.
    Participants
        Proxy       : maintains a reference that lets the proxy access the real subject. Provides an interface identical
                      to subjects so that a proxy can be substituted for the real object. Controls access to the real subject
                      and may be responsible for creating and deleting it. 
            remote proxies     :  are responsible for encoding a request and its arguments and for sending the encoded request 
                                  to the real subject in a different address space.
            virtual proxies    : may cache additional information about the real subject so that they can postpone accessing it. 
            protection proxies :  check that the caller has the access permissions required to perform a request.

        Subject     : defines the common interface for realsubject and proxy so that a proxy can be used anywhere a realsubject is expected
        RealSubject : defines the real object that the proxy represents
 */

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MathProxy proxy = new MathProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            Console.ReadKey();
        }
    }
}