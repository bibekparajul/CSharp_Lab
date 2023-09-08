using System;

namespace LabWork2
{
    public class Program
    {
        public int field = 100; //field
        public int Property { get; set; }  //property

        public int PropertyExpanded {
            get
            {
                return field;
            }
            set {
                field = value;
            }

        } 

        public static void Main(String[] args)
        {
            Program P = new Program();
            Console.WriteLine("value of field: "+ P.field);
            Console.WriteLine("value of property: "+P.Property);
            Console.WriteLine("value of other property: "+P.PropertyExpanded);
            
        
    }
    }
}