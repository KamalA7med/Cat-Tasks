using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Notification_System
{
    internal class EmailService : NotificationService
    {
        public void Notify(Order order)
        {
            Console.WriteLine($"Email Sent : ");
            order.format_order_message();
        }
    }
}
