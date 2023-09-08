using Polymorphism.MethodOverloading;
using Polymorphism.OperatorOverloading;
using System;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // int resultInt1 = Operation.Add(11, 2);
           // Console.WriteLine("result of two integer parameter:"+resultInt1);
           //int  resultInt2 = Operation.Add(2, 4, 5);
           // Console.WriteLine("result of three integer parameter:" + resultInt2);

           // decimal resultDecimal1 = Operation.Add(3.1m, 6.0m, 5.8m);
           // Console.WriteLine("result of two decimal parameter:" + resultDecimal1);
           // decimal resultDecimal2 = Operation.Add(7.1m, 4.0m);
           // Console.WriteLine("result of three decimal parameter:" + resultDecimal2);



            Rectangle R1 = new Rectangle
            {
                Length = 20,
                Breadth = 5
            };
            Rectangle R2 = new Rectangle
            {
                Length = 4,
                Breadth = 4
            };
            Rectangle R3 = R1 + R2;
            Console.WriteLine("total length:"+R3.Length);
            Console.WriteLine("total breadth:"+R3.Breadth);
            
        }
    }
}