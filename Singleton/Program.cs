
/*
    Singleton design pattern ensures a class has only one instance
    and provides a global point of access to it.

    Participants
        Singleton : defines an instance operation that lets clients access
                    its unique instance. Responsible for creating and maintaining its own unique instance
 */

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2) { Console.WriteLine("Same instance"); }

            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 10; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch request to: " + server);
            }

            Console.ReadKey();
        }
    }
}