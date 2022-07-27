
namespace Singleton
{
    public class LoadBalancer
    {
        static LoadBalancer instance;
        List<string> servers = new List<string>();
        Random random = new Random();

        // Lock synchronization object
        private static object locker = new object();

        protected LoadBalancer()
        {
            servers.Add("server1");
            servers.Add("server2");
            servers.Add("server3");
        }

        /*
         Support multithread applications through
         "double checked locking" pattern which
         once the instance exists avoid locking
         each time the method is invoked
         */
        public static LoadBalancer GetLoadBalancer()
        {
            if(instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }

            return instance;
        }

        // Random load balancer
        public string Server
        {
            get 
            { 
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }
    }
}
