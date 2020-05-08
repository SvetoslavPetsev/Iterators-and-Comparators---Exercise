namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> myIterator = null;
            
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    if (input.Contains("Create"))
                    {
                        List<string> list = input.Split().Skip(1).ToList();
                        myIterator = new ListyIterator<string>(list);
                    }
                    else if (input == "Move")
                    {
                        Console.WriteLine(myIterator.Move());
                    }

                    else if (input == "HasNext")
                    {
                        Console.WriteLine(myIterator.HasNext());
                    }

                    else if (input == "Print")
                    {
                        myIterator.Print();
                    }

                    else if (input == "PrintAll")
                    {
                        foreach (var item in myIterator)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
