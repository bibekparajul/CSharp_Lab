namespace AsyncAwaitPractice
{
    class Program
    {
        public static async Task Main(String[] args)
        {
            Console.WriteLine("Processing Order..."); //1
            var email = SendEmail();
            Console.WriteLine("Processing Completed!!!");  //3
            Console.WriteLine("Waiting for email to be sent!!!"); //4
            await email;      //5
            Console.WriteLine("All Done");  //7
        }

        public static async Task SendEmail()
        {
            Console.WriteLine("Sending Email"); //2
            await Task.Delay(5000);        
            Console.WriteLine("Email Sent!!");   //6
        }
    }
}