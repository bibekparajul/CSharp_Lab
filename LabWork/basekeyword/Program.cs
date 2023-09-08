namespace baseKeyword
{
    public class Animal
    {
        public virtual void display()
        {
            Console.WriteLine("this is animal ");
        }

    }

    public class Cat: Animal
    {
        public override void display()
        {
            base.display();
            Console.WriteLine("this is cat");
        }


    }
    public class Program
    {
        public static void Main()
        {
            Cat c = new Cat();
            
            c.display();
            
        }
    }
}