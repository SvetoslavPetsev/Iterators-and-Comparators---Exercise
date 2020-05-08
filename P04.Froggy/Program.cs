namespace IteratorsAndComparators
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Console
                .ReadLine()
                .Split(new char[] {',' , ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(input);
            
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
