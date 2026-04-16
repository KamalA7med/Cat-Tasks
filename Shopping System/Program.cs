using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ConsoleApp11
{
    
   
    
    
    

   


    internal class Program
    {
        public static List<Item> GetDefaultShopItems()
        {
            return new List<Item>
    {
       
        new Item("Tomato", 5, "Fresh tomatoes", 50),
        new Item("Potato", 4, "Organic potatoes", 60),
        new Item("Onion", 3, "Yellow onions", 70),
        new Item("Apple", 6, "Red apples", 40),
        new Item("Banana", 5, "Sweet bananas", 50),
        new Item("Orange", 4, "Juicy oranges", 45),
        new Item("Cucumber", 3, "Fresh cucumbers", 30),
        new Item("Carrot", 3, "Crunchy carrots", 35),
        new Item("Pepper", 6, "Green peppers", 25),

      
        new Item("Water", 2, "Mineral water", 100),
        new Item("Juice", 10, "Orange juice", 30),
        new Item("Cola", 12, "Soft drink", 25),
        new Item("Milk", 8, "1L milk", 35),
        new Item("Tea", 15, "Tea box", 20),
        new Item("Coffee", 20, "Ground coffee", 15),

       
        new Item("Bread", 3, "Whole bread", 40),
        new Item("Croissant", 7, "Fresh croissant", 25),
        new Item("Cake", 25, "Chocolate cake", 10),
        new Item("Biscuits", 6, "Crunchy biscuits", 30),
        new Item("Donut", 5, "Sweet donut", 20),

       
        new Item("Chips", 8, "Potato chips", 35),
        new Item("Chocolate", 12, "Chocolate bar", 40),
        new Item("Candy", 5, "Mixed candy", 50),
        new Item("Popcorn", 7, "Butter popcorn", 20),
        new Item("Nuts", 18, "Mixed nuts", 15),

        new Item("Chicken", 50, "Fresh chicken", 20),
        new Item("Beef", 80, "Fresh beef", 15),
        new Item("Cheese", 30, "Cheddar cheese", 25),
        new Item("Yogurt", 6, "Natural yogurt", 40),
        new Item("Eggs", 20, "Egg tray", 30),

       
        new Item("Soap", 10, "Hand soap", 50),
        new Item("Shampoo", 25, "Hair shampoo", 20),
        new Item("Toothpaste", 15, "Mint toothpaste", 30),
        new Item("Tissue", 12, "Tissue box", 40),
        new Item("Detergent", 35, "Laundry detergent", 15)
    };
        }


        static void Main(string[] args)
        {
            User user = new User("Kamal Ahmed ", 10000,new Cart());
            Shopping_System_UI UI = new Shopping_System_UI(user, GetDefaultShopItems());
            while (true) {
                Console.Clear();
                UI.Show_Menu();
                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (option == 7)
                {
                    
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("         Signed Out ");
                    Console.WriteLine("---------------------------------");
                    break;
                }
                
                switch(option)
                {
                    case 1:
                        UI.List_Shop_Items();
                        break;
                    case 2:
                        UI.ViewCart();
                        break;
                    case 3:
                        UI.Add_item_To_cart();
                        break;
                    case 4:
                        UI.Remove_item_from_Cart();
                        break;
                    case 5:
                        UI.UndoLastOperation();
                        break;
                    case 6:
                        UI.Checkout();
                        break;
                }
                Console.WriteLine("\n\nEnter any Key To Continue .............");
                Console.ReadKey();


                    }

           
        }
    }
}
