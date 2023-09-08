using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    public class Person
    {

        public string Name;
        public string Symbolno;

        public Person()       //no parameter
        {
            Name = "Nick";
            Symbolno = "00011A";
        }

        public Person(string name, string symbolno)
        {
            Name = name;
            Symbolno = symbolno;
        }   

    }
}
