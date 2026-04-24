using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Notification_System
{
    internal class SMSService:NotificationService
    {
        public void Notify(Order order)
        {
            Console.WriteLine($"SMS Message Sent : ");
            order.format_order_message();
        }
    }
}
