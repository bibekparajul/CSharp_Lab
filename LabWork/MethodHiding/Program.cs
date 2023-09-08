namespace MethodHiding
{
    class Car
    {
        public void display()
        {
            Console.WriteLine("this is a car class");

        }
    }
    class Ford: Car
    {
        public new void display()
        {
            Console.WriteLine("this is a ford class");
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Car c = new Car();
            c.display();
            Ford f = new Ford();
            f.display();

        }
    }
}