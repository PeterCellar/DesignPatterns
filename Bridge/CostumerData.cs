
namespace Bridge
{

    // The ConcreteImplementor class
    public class CostumerData : DataObject
    {
        private readonly List<string> customers = new List<string>();
        private int current = 0;
        private string city;

        public CostumerData(string city)
        {
            this.city = city;

            customers.Add("Jim Jones");
            customers.Add("Samual Jackson");
            customers.Add("Allen Good");
            customers.Add("Ann Stills");
            customers.Add("Lisa Giolani");
        }

        public override void NextRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void AddRecord(string name)
        {
            customers.Add(name);
        }

        public override void DeleteRecord(string name)
        {
            customers.Remove(name);
        }

        public override string GetCurrentRecord()
        {
            return customers[current];
        }

        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }

        public override void ShowAllRecord()
        {
            Console.WriteLine("Customer City: " + city);

            foreach(string customer in customers)
            {
                Console.WriteLine(" " + customer);
            }
        }
    }
}
