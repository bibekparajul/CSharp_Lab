using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassEx.Part1
{
    internal partial class MyClass
    {
        public void Display1()
        {
            Console.WriteLine("I am part1 class");
        }
    }

    internal partial class MyClass
    {
        public void Display2()
        {
            Console.WriteLine("I am part2 class");
        }
    }
}
