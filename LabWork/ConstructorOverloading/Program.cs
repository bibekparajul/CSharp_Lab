namespace ConstructorOverloading
{
    public class Program
    {
        public static void Main()
        {
            Person firsrPerson = new Person();

            Person secondPerson = new Person("Bibek Parajuli", "23424");


            Console.WriteLine("Person object having no parameter ");
                Console.WriteLine("Name is: " + firsrPerson.Name);
            Console.WriteLine("Person object having parameter: ");
            Console.WriteLine(secondPerson.Name + " has symbol no: " + secondPerson.Symbolno);
        }
    }
}