namespace LinqPractice
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("----LINQ----");
            int[] age = { 22, 12, 33, 44, 11, 66 };
            var a = from i in age where i > 30 select i;

            foreach(int item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}