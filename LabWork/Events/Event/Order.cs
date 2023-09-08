

namespace Events.Event
{
    internal class Order
    {
        public int Id { get; set; }
        
        public decimal Total { get; set; }

        public string CustomerName { get; set; }    
    }
}
