using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.SqlServer.Server;

namespace Order_Notification_System
{
    internal interface NotificationService
    {
         void Notify(Order order);
    }
    static class Order_Extensions
    {
        public static void  format_order_message(this Order order)
        {
            Console.WriteLine($"\nOrder Details : ");
            
            Console.WriteLine($"Order Id :{order.Id}");
            Console.WriteLine($"Order Name :{order.Name}");
            Console.WriteLine($"Order Description :{order.Description}");
            Console.WriteLine($"Order Price :{order.Price}\n\n");
            

        }
    }


}
