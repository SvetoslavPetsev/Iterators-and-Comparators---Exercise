namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;
            string cmd;
            while ((cmd = Console.ReadLine()) != "END")
            {
                try
                {
                    if (cmd.Contains("Create"))
                    {
                        List<string> items = cmd.Split().Skip(1).ToList();
                        listyIterator = new ListyIterator<string>(items);
                    }

                    else if (cmd == "Print")
                    {
                        listyIterator.Print();
                    }

                    else if (cmd == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (cmd == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine( ex.Message );
                }   
            }
        }
    }
}
