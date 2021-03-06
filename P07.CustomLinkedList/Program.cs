﻿namespace IteratorsAndComparators
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var linkedList = new DoublyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            linkedList.ForEach(Console.WriteLine);
            Console.WriteLine(linkedList.Count == 3);

            Console.WriteLine(linkedList.RemoveFirst());
            Console.WriteLine(linkedList.RemoveLast());

            int[] arr = linkedList.ToArray();
            Console.WriteLine(string.Join(" - ", arr));

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(linkedList.Contains(5));
            Console.WriteLine(linkedList.Contains(1));
        }
    }
}
