namespace EnumPractice
{
    class Program
    {
        public static void Main()
        {
            Days d = Days.Friday;
            Status s = Status.ac;
            Console.WriteLine("Value of " + d + " is " + (int)d);
            Console.WriteLine("Value of " + s + " is " + (int)s);

        }
    }
}