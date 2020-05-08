namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        int index;

        public ListyIterator(List<T> list)
        {
            this.list = list;
            this.index = 0;
        }

        public bool HasNext()
        {
            if (this.index < this.list.Count - 1)
            {
                return true;
            }
            return false;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (this.list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.list[this.index]);
            }
                
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var currentItem in this.list)
            {
                yield return currentItem;
            }   
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
