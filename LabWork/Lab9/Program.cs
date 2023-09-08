using System;

namespace Lab9
{
    public class Program
    {
        public static void Main()
        {
            int val = 10;
            Users U = new Users { Name = "Bibek", Roll = 23424 };
            Modify(val);
            Modify(U);
            Console.WriteLine(val);
            Console.WriteLine(U.Roll);
            Console.WriteLine(U.Name);

        }

        public static void Modify(int n)
        {
            n = 5;
        }
        public static void Modify(Users user)
        {
            user.Roll = 23424076;
            user.Name = "Bibek Parajuli";
        }
    }

    public class Users
    {
        public String Name { get; set; }

        public int Roll { get; set; }
    }
}