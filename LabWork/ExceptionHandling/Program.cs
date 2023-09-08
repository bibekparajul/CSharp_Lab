using System;
namespace ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            

            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("this is finally block");
            }
        }
    }
}