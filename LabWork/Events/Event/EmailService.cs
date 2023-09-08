using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Event
{
    internal class EmailService
    {

        public void SendEmail(object source, EventArgs e)
        {
            Console.WriteLine("---Sending email to customer---");

        }
    }
}
