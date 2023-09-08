using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class Animal
    {
        public String Name { get; set; }

        public int age { get; set; }


        //default constructor
        public Animal()
        {
            Name = "Dog";
            age = 14;
        }

        //parameterized constructor
        public Animal(string name, int age)
        {
            Name = name;
            this.age = age;
        }
    }
}
