namespace DelegatesPractice2
{
    class Program
    {
        public static void Main()
        {
            //Func, Predicate, Action vaneko wrapper to deligate
            //Action => return typep hudaina 

            Console.WriteLine("--Using Action--");
            Action<int, int> A = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            A(1, 2);

            //func
            Console.WriteLine("--Using Func--");
            Func<int, int, int> B = (x, y) =>      //lasst ko int vaneko return type ho
            {
                return (x * y);
            };
            int result = B(11, 2);
            Console.WriteLine(result);


            //predicate

            Console.WriteLine("--Using Predicate--");
            Predicate<int> C = (x) =>      //lasst ko int vaneko return type ho
            {
                return true;
            };
            bool res = C(1);
            Console.WriteLine(res);

        }
    }
}