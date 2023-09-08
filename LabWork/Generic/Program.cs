using System;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {



            MyList<int> l = new MyList<int>(5);
            l[0] = 11;
            l[1] = 33;
            l[4] = 55;


            Console.WriteLine("Index0:" + l[0]);
            Console.WriteLine("Index1:" + l[1]);
            Console.WriteLine("Index4:" + l[4]);


            MyList<string> name = new MyList<string>(5);
            name[0] = "Bek";
            name[1] = "Bbek";
            name[3] = "Raaju";


            Console.WriteLine("Index 0 name:" +name[0]);
            Console.WriteLine("Index 1 name:" + name[1]);
            Console.WriteLine("Index 3 name:" + name[3]);


        }
    }
}