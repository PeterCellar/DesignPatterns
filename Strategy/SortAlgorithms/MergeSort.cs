
namespace Strategy.SortAlgorithms
{
    public class MergeSort : SortStrategy
    {
        public static void MainMerge<T>(List<T> values, int left, int mid, int right) where T : IComparable<T>
        {
            List<T> temp = new List<T>();
            int i, eol, pos;

            eol = (mid - 1);
            pos = left;
            //num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                Console.WriteLine("Pos " + pos + ", mid " + mid);
                if (values.ElementAt(left).CompareTo(values.ElementAt(mid)) > 0) { temp[pos++] = values.ElementAt(left++); }
                else { temp[pos++] = values.ElementAt(mid++); } // out of range
            }

            while (left <= eol)
            {
                temp[pos++] = values.ElementAt(left++); 
            }

            while (mid <= right)
            {
                values[right] = temp.ElementAt(right);
                right--;
            }
        }


        public static void SortMerge<T>(List<T> values, int left, int right) where T : IComparable<T>
        {
            int mid;

            if(right > left)
            {
                mid = (right + left) / 2;
                SortMerge(values, left, mid);
                SortMerge(values, (mid + 1), right);
                MainMerge(values, left, (mid + 1), right);
            }
        }

        public override void Sort(List<string> list)
        {
            //SortMerge(list, 0, (list.Count - 1));
            Console.WriteLine("MergeSorted list ");
        }
    }
}
