using System;

namespace LabWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal obj1= new Animal();
            Console.WriteLine("Default Constructor");
            Console.WriteLine(obj1.Name);
            Console.WriteLine(obj1.age);
            Console.WriteLine("Parameterized  Constructor");
            Animal obj2= new Animal("Tiger",9);
            Console.WriteLine(obj2.Name+ " " + obj2.age);
            //Console.WriteLine(obj2.age);

        }

    }
}
