using System;

namespace Lab3
{
    public class Program
    {

    public static void Main()
    {
            Console.WriteLine("Contextual Keyword ");
            int where = 33;
            Console.WriteLine("the value of where is: "+where);
            MyMethod(90);

    }
        public static void MyMethod(int @class)
        {
            // class is a contextual keyword, but it can be used as an identifier
            Console.WriteLine($"The value of @class : {@class}");
        }


    }

}