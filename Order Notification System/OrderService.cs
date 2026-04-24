using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Notification_System
{
    internal class OrderService
    {
       public event Action<Order> OnPlacedOrder;
        public Predicate<Order> Filter_Notifactions;

        public void Place_order(Order order)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("          Order placed successfully:-)");
           if(Filter_Notifactions!=null&& Filter_Notifactions(order))
            {
                OnPlacedOrder(order);
               
            }
            Console.WriteLine("---------------------------------------------");

        }
    }
}
