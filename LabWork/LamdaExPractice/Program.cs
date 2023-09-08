namespace LamdaExPractice
{
    class Program
    {
        public static void Main()
        {

            //lamda expression
            //Func<int, int, int> A = (x, y) => x + y;    //expression lamda

           
            
            Func<int, int, int> A1 = (x, y) =>     //statement lamda
            {
                return x + y;
            };

            List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> f = l.Where(x => x > 7)
                .ToList();
            Console.WriteLine("--Lamda Expression--");
            foreach(int x in f)
            {
                Console.WriteLine(x);
            }
        }
    }
}