namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var personHash = new HashSet<Person>();
            var personSorted = new SortedSet<Person>();

            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);
                var person = new Person(name, age);
                personHash.Add(person);
                personSorted.Add(person);
            }

            Console.WriteLine(personSorted.Count);
            Console.WriteLine(personHash.Count);
        }
    }
}
