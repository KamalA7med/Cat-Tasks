using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Notification_System
{
    
    internal class Program
    {
        public static List<Order> Get_Orders()
        {
            return new List<Order>
    {
        new Order(1, "Laptop", 1500, "High-performance laptop for programming and gaming"),
        new Order(2, "Smartphone", 800, "Latest model with excellent camera"),
        new Order(3, "Headphones", 120, "Noise-cancelling wireless headphones"),
        new Order(4, "Keyboard", 70, "Mechanical keyboard with RGB lighting"),
        new Order(5, "Monitor", 300, "27-inch 4K UHD display")
    };
        }
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            NotificationService Email=new EmailService();
            NotificationService WhatsApp =new WhatsAppService();
            NotificationService SMS=new SMSService();
            List<Order> orders = Get_Orders();
            service.OnPlacedOrder += Email.Notify;
            service.OnPlacedOrder += WhatsApp.Notify;

            service.OnPlacedOrder += SMS.Notify;
            service.Filter_Notifactions = (Order O) => O.Price >= 800;
            foreach(Order o in orders)
            {
                service.Place_order(o);
            }




        }
    }
}
