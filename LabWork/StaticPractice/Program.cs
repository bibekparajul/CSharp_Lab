namespace StaticPractice
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int res = Calculation.Mul(23, 3);
            Console.WriteLine("Multiplication result is: "+res);
            res = Calculation.Div(20,2);
            Console.WriteLine("Division  result is: "+res);
        }
    }
}