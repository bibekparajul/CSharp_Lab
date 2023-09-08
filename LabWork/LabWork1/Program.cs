using System;

namespace LabWork1
{
    public class Program
    {
        public static void Main(String[] args) 
        {
        Time t = new Time();   //object t banako 
            Console.WriteLine("Default Constructor: ");
            Console.WriteLine(t.hour);
            Console.WriteLine(t.sec);



            Console.WriteLine("Parameterized  Constructor: ");
            Time t2 = new Time(1, 9, 4);  //t2 vaneko arko obj
            Console.WriteLine(t2.hour);
            Console.WriteLine(t2.min);

        }
        
    }

   
}