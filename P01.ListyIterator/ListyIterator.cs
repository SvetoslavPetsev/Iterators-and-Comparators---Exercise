using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class ListyIterator<T>
    {
        private List<T> list;
        private int index;
        public ListyIterator(List<T> list)
        {
            this.list = list;
            this.index = 0;
        }

        public List<T> List { get; set; }

        public bool Move()
        {     
            if (HasNext())
            {
                this.index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.index < this.list.Count - 1)
            {
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
    }
}
