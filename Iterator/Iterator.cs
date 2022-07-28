using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Iterator : IAbstractIterator
    {
        Collection collection;
        int current = 0;
        int step = 1;

        public Iterator(Collection collection)
        {
            this.collection = collection;
        }

        public Item First()
        {
            current = 0;
            return collection[current];
        }

        public Item Next()
        {
            current += step;
            if (!IsDone)
            {
                return collection[current];
            }
            else
                return null;
        }

        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        public Item CurrentItem
        {
            get { return collection[current]; }
        }

        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}
