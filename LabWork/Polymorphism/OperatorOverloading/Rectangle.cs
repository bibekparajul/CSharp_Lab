using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.OperatorOverloading
{
    internal class Rectangle
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public static Rectangle operator +(Rectangle R1, Rectangle R2)
        {
            Rectangle r = new Rectangle();
            r.Length = R1.Length + R2.Length;
            r.Breadth = R1.Breadth + R2.Breadth;
            return r;
        }
    }
}
