namespace DelegatesPractice
{
    delegate int Operation(int x, int y);

    class Calculation
    {
        // Define some methods that match the delegate signature
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Substract(int x, int y)
        {
            return x - y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create delegate instances
            Operation add = new Operation(Calculation.Add);
            Operation subs = new Operation(Calculation.Substract);

            // Use the delegate instances to call the methods
            int result1 = add(2, 4); 
            int result2 = subs(11, 4);
            Console.WriteLine("Addition result: "+result1);
            Console.WriteLine("Substraction result: "+result2);

        }
    }
}