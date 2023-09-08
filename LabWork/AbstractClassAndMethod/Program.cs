public abstract class Animal
{
    public string Name { get; set; }

    public abstract void Display();
}

public class Cat : Animal
{
    public Cat(string name)
    {
        Name = name;

    }
    public override void Display()
    {
        Console.WriteLine($"This cat name is {Name}");
    }
}

public class Program
{
    public static void Main()
    {
        Animal cat = new Cat("Pilo");
        cat.Display();

    }
}