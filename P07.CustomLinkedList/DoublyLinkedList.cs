namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private ListNode head;
        private ListNode tail;
        private class ListNode
        {
            public ListNode(T value)
            {
                this.Value = value;
            }
            public T Value { get; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
        }
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            if (this.Count == 0)
            {
                CreateList(value);
            }
            else
            {
                ListNode newHead = new ListNode(value);
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }
            this.Count++;
        }
        public void AddLast(T value)
        {
            if (this.Count == 0)
            {
                CreateList(value);
            }
            else
            {
                ListNode newHead = new ListNode(value);
                newHead.PreviousNode = this.tail;
                this.tail.NextNode = newHead;
                this.tail = newHead;
            }
            this.Count++;
        }
        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                ThrowEmptyListException();
            }

            var firstElement = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }

            this.Count--;
            return firstElement;
        }
        public T RemoveLast()
        {
            T lastElement = this.tail.Value;

            if (this.Count == 0)
            {
                ThrowEmptyListException();
            }

            this.tail = this.tail.PreviousNode;

            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }

            this.Count--;
            return lastElement;
        }
        public void ForEach(Action<T> action)
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
        public T[] ToArray()
        {
            T[] newArr = new T[this.Count];
            int index = 0;

            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                newArr[index] = currentNode.Value;
                currentNode = currentNode.NextNode;
                index++;
            }

            return newArr;
        }

        public bool Contains(T element)
        {
            ListNode currentNode = this.head;
            while (currentNode != null)
            {
                if (element.CompareTo(currentNode.Value) == 0)
                {
                    return true;
                }
                currentNode = currentNode.NextNode;
            }
            return false;
        }
        private static void ThrowEmptyListException()
        {
            throw new InvalidOperationException("The LinkedList is empty.");
        }
        private void CreateList(T value)
        {
            ListNode newHead = new ListNode(value);
            this.head = this.tail = newHead;
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
