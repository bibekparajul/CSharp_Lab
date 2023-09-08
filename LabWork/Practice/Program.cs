

using System;

class Calculation
{
    public void Addd()
    {
        Console.WriteLine("Hello");
    }
    public  int Add(int x, int y)
    {
        return x + y;
    }
}

class Program
{

    public static void Main()
    {

    Calculation c1 = new Calculation();
        var c = c1.Add(11,2);
        Console.WriteLine(c.ToString());
    
    }
}