public sealed class MySealedClass
{
    public int MyProperty { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        MySealedClass sealedInstance = new MySealedClass();
        sealedInstance.MyProperty = 42;

        Console.WriteLine(sealedInstance.MyProperty);
    }
}
