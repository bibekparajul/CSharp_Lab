

namespace Polymorphism.MethodOverloading
{
    internal static  class Operation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }        
               
             
        
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }       
        
        public static decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;

        }

    }
}
