using System;

namespace Inheritance
{
    public class Program
    {
        public static void Main()
        {
            Rectangle r = new Rectangle
            {
                Length = 10,
                Breadth = 20
            };

            Square s = new Square
            {
                Length = 6
            };

            r.Area();
            r.Perimeter();
            s.Area();

            //Shape S1 = new Shape();    //abstract use garyo vaney Shape class ma  yo paidaina 
        }


    }
}