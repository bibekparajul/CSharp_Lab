using System;

namespace Lab7
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Do While Loop");
            Console.WriteLine("Enter the number of line to print the pattern : ");
            int n = int.Parse(Console.ReadLine());
            int i = 1, j;
            do
            {
                if (i < n)
                {
                    j = 0;
                    do
                    {
                        Console.Write(" ");
                        j++;
                    } while (j < n - i);
                }
                j = 0;
                do
                {
                    Console.Write("*");
                    j++;
                } while (j < i);
                Console.WriteLine();
                i++;
            } while (i <= n);
        }
    }
}