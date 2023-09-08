
using System;
namespace Arguments_Named_Positional_optional
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Positional Args");

            DisplayInfo(5, "Bbek", "Nepali");        //positional args

            Console.WriteLine("Named Args");

            DisplayInfo(name: "Jack", age: 33, nationality: "USA"); //named ards
            
            Console.WriteLine("optional Args");

            Display("Bibek Parajuli"); //optional args


        }

        public static void DisplayInfo(int age, string name, string nationality)  //string nationality = "Nepal"
        {
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Nationality:" + nationality);
        }
        public static void Display(string name,int symbolno = 23424)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Symbol no: " + symbolno);
        }
    }


}
