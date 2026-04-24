using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Notification_System
{
    internal class WhatsAppService:NotificationService
    {
        public void Notify(Order order)
        {
            Console.WriteLine($"Whats App Message Sent : ");
            order.format_order_message();
        }
    }
}
