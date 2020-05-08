namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input.Contains("Push"))
                {
                    List<string> list = input.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();
                    foreach (var item in list)
                    {
                        myStack.Push(item);
                    }
                }
                else if (input == "Pop")
                {
                    myStack.Pop();
                }
            }
            myStack.Print();
        }
    }
}
