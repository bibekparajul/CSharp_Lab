using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Square : Shape
    {
        //public override void  Area()
        public void Area()
        {
            int area = Length * Length;

            Console.WriteLine($"the area  for square when {Length} is:" + area);
        }


    }
}
