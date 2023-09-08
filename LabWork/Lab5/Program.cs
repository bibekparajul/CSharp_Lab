using System;

namespace Lab5
{
    public class Program {

        public static void Main(string[] args)
        {

            Console.WriteLine("For Loop");
            Console.Write("Enter the number of line to print the pattern : ");
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++) {
                    Console.Write(" "); 
                }
                for (int j = 0; j < i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

}