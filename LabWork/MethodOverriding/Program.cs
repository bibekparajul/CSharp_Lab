namespace MethodOverriding
{
    class Car
    {
        public virtual void display()
        {
            Console.WriteLine("This is a car class");
        }
    }

    class Ford: Car
    {
        public override void display()
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