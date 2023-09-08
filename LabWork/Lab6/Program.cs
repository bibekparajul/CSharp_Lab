using System;
namespace Lab6
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("While Loop");
            Console.WriteLine("Enter the number of line to print the pattern : ");
            int n = int.Parse(Console.ReadLine());
             int i = 1;
            int j;
            while (i <= n)
            {
                j = 0;
                while (j < n - i)
                {
                    Console.Write(" ");
                    j++;
                }
                j = 0;
                while(j < i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }

        }
    }


}