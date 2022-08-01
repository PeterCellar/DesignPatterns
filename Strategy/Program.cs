
/*
    Strategy desing pattern defines a family of algorithms, encapsulate each one,
    and make them interchangable.

    Participants
        Strategy          : declares an interface common to all supported algortihms. Context uses
                            this interface to call the algorithm defined by a Concrete Strategy
        Concrete Strategy : implements the algorithm using the Strategy interface
        Context           : is configured with a Concrete Strategy object, maintains a reference to a Strategy object
                            may define an interface that lets Strategy access its data
 */

using Strategy.SortAlgorithms;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}