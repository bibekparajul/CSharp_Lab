using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Event
{
    internal class OrderProcessor
    {

        public delegate void OrderProcessedHandler(object source, EventArgs e); //define delegate
        public event OrderProcessedHandler OrderProcessed;//define events based on delegate

        public void Process(Order O)
        {
            Console.WriteLine("----Processing Order----------");

            //ToDo: Logic here

            Console.WriteLine("-----Processing Completed------");
            OnOrderProcessed(); 
           
        }

        protected virtual void OnOrderProcessed()
        {
            if(OrderProcessed != null)
                OrderProcessed(this, EventArgs.Empty);      //raise the event
        }
    }
}
