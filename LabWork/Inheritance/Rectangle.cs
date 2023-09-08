using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Rectangle : Shape
    {


        //public override void Area()
        public void Area()
        {
            int area = Length * Breadth;
            Console.WriteLine("the area for rectangle is:" + area);
        }

        public void Perimeter()
        {

            int per = 2 * (Length + Breadth);
            Console.WriteLine("the perimeter of rectangle is: " + per);
        }
    }
}
