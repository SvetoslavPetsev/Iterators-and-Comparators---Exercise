namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private List<T> stack;
        private int index;

        public Stack()
        {
            this.stack = new List<T>();
            this.index = 0;
        }
        public bool HasElement()
        {
            if (stack.Count != 0)
            {
                return true;
            }
            return false;
        }
        public void Pop()
        {
            if (HasElement())
            {
                this.stack.RemoveAt(stack.Count - 1);
            }
            else
            {
                Console.WriteLine("No elements");
            }
        
        }

        public void Print()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = stack.Count - 1; j >= 0; j--)
                {
                    Console.WriteLine(stack[j]);
                }
            }
        }
        public void Push(T item)
        {
            this.stack.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.stack)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
