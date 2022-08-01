using Strategy.SortAlgorithms;

namespace Strategy
{
    public class SortedList
    {
        private List<string> list = new List<string>();
        private SortStrategy sortStrategy;
        
        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            sortStrategy.Sort(list);

            foreach(string name in list)
            {
                Console.Write(" " + name);
            }

            Console.WriteLine();
        }
    }
}
