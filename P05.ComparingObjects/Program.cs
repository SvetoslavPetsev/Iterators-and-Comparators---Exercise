namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split();
                string name = info[0];
                int age = int.Parse(info[1]);
                string town = info[2];

                var person = new Person(name, age, town);
                people.Add(person);
            }

            int peopleCompare = int.Parse(Console.ReadLine());
            int countOfMatches = 1;
            int countOfNotEqual = 0;

            Person targetPerson = people[peopleCompare - 1];
            foreach (var person in people)
            {
                if (person == targetPerson)
                {
                    continue;
                }
                if (person.CompareTo(targetPerson) == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    countOfNotEqual++;
                }
            }

            if (countOfMatches != 1)
            {
                Console.WriteLine($"{countOfMatches} {countOfNotEqual} {people.Count}");
            }

            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
