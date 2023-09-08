using System;

namespace Lab8
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("For eachloop");
        int[] arr = { 1, 2, 3, 4, 5, 6 };
            string[] cars = { "Ford", "Swift", "Bugati" };
        foreach(int value in arr)
        {
            Console.WriteLine(value);
        }

        foreach(String val in cars)
            {
                Console.WriteLine(val);
            }
        }
    }
}