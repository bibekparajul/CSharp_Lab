using Events.Event;

namespace Events
{
    class Program
    {
        public static void Main()
        {
            Order O = new Order
            {
                Id = 1,
                CustomerName = "Bibek",
                Total = 2222,

            };

            EmailService emailService = new EmailService();
            OrderProcessor op = new OrderProcessor();
            op.OrderProcessed += emailService.SendEmail;
            op.Process(O);
        }
    }
}