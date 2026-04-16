using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    enum Operation_type { AddItem, RemoveItem };
    internal class Shopping_System_UI
    {
        private User _User;
        private Stack<(Item item, Operation_type Operation)> _History;
        private List<Item> _ShopItems;
        public Shopping_System_UI(User user, List<Item> ShopItems)
        {
            _User = user;
            _History = new Stack<(Item item, Operation_type Operation)>();
            _ShopItems = ShopItems;
        }
        public void ViewCart()
        {
            Console.WriteLine("+----------------------+------------+----------+--------------------------------+");
            Console.WriteLine(" | Name                 | Price      | Quantity | Description                    |");
            Console.WriteLine("+----------------------+------------+----------+--------------------------------+");
            int item_id = 0;
            foreach (var item in _User.Cart.Items)
            {
                Console.WriteLine($"{item_id}| {item.Name,-20} | {item.Price,-10} | {item.Qunatity,-8} | {item.Description,-30} |");

                item_id++;
            }

            Console.WriteLine("+----------------------+------------+----------+--------------------------------+");

        }
        public void Checkout()
        {
            double TotalCost = 0;
            Console.WriteLine("+----------------------+------------+----------+--------------+");
            Console.WriteLine("| Name                 | Price      | Quantity | Cost    ");
            Console.WriteLine("+----------------------+------------+----------+--------------+");

            foreach (var item in _User.Cart.Items)
            {
                double Cost = item.Price * item.Qunatity;
                TotalCost += Cost;
                Console.WriteLine("| {0,-20} | {1,-10} | {2,-8} | {3,-10} |",
                    item.Name,
                    item.Price,
                    item.Qunatity, Cost
                    );
            }

            Console.WriteLine("+----------------------+------------+----------+--------------+");
            Console.WriteLine($"\n\nTotal Cost :{TotalCost} ");
            Console.Write("\n\n Would You Like to confirm The operation [Y/N]? ");
            if (_User.Balance >= TotalCost)
            {
                char ch = (Convert.ToChar(Console.ReadLine().ToUpper()));
                if (ch == 'Y')
                {
                    _User.Cart.Items.Clear();
                    Console.WriteLine("Done Successfully");
                    _User.Balance -= TotalCost;
                    _History.Clear();
                }
                else
                {
                    Console.WriteLine("Operation Was Canceled");
                }

            }
            else
            {
                Console.WriteLine("You Don not Have enough Balace To confrim the operation ");

            }



        }
        public void List_Shop_Items()
        {
            Console.WriteLine("+----------------------+------------+----------+--------------------------------+");
            Console.WriteLine("id | Name                 | Price      | Quantity | Description                    |");
            Console.WriteLine("+----------------------+------------+----------+--------------------------------+");
            int item_id = 0;
            foreach (var item in _ShopItems)
            {
                Console.WriteLine($"{item_id,-3}| {item.Name,-20} | {item.Price,-10} | {item.Qunatity,-8} | {item.Description,-30} |");

                item_id++;
            }

            Console.WriteLine("+----------------------+------------+----------+--------------------------------+");

        }
        public void Add_item_To_cart()
        {
            char answer;
            List_Shop_Items();
            do
            {
                Console.Write("Enter items id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Quantity : ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (_ShopItems[id].Qunatity >= quantity)
                {
                    _ShopItems[id].Qunatity = _ShopItems[id].Qunatity - quantity;
                    Item item = new Item(_ShopItems[id].Name, _ShopItems[id].Price, _ShopItems[id].Description, quantity);
                    _History.Push((item, Operation_type.AddItem));
                    _User.Cart.Additem(item);

                    Console.WriteLine("Done Successfully");
                }
                else
                {
                    Console.WriteLine("The whole Quantity are not avaliable \n \n Try Again ");
                }
                Console.Write("Would you like to Add another Items [Y/N] : ");
                answer = (Convert.ToChar(Console.ReadLine().ToUpper()));
            } while (answer == 'Y');


        }
        public void Remove_item_from_Cart()
        {

            char answer;
            do
            {
                ViewCart();
                Console.Write("Enter items id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                _History.Push((_User.Cart.Items[id], Operation_type.RemoveItem));
                _User.Cart.Romove(id);
                Console.WriteLine("Done Successfully");

                Console.Write("Would you like to Remove another Items [Y/N] : ");
                answer = (Convert.ToChar(Console.ReadLine().ToUpper()));
            } while (answer == 'Y');

        }
        private char Show_Last_Operation((Item item, Operation_type Operation) last_operation, string text)
        {
            Console.WriteLine($"{text} Item: ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("| Name                 | Price      | Quantity | Description                    |");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"| {last_operation.item.Name,-20} | {last_operation.item.Price,-10} | {last_operation.item.Qunatity,-8} | {last_operation.item.Description,-30} |",

            last_operation.item.Name,
            last_operation.item.Price,
            last_operation.item.Qunatity,
            last_operation.item.Description);
            Console.WriteLine("--------------------------------------------------------------------------------");


            Console.Write("Would you like to contiune ? [Y/N]");
            char option = Convert.ToChar(Console.ReadLine().ToUpper());
            return option;
        }
        public void UndoLastOperation()
        {
            if (_History.Count > 0)
            {
                var last_operation = _History.Pop();
                if (last_operation.Operation == Operation_type.RemoveItem)
                {
                    char option = Show_Last_Operation(last_operation, "Add");
                    if (option == 'Y')
                    {
                        _User.Cart.Additem(last_operation.item);
                        Console.WriteLine("Added Successfully ");

                    }
                    else
                    {
                        _History.Push(last_operation);
                    }

                }
                else if (last_operation.Operation == Operation_type.AddItem)
                {
                    char option = Show_Last_Operation(last_operation, "Remove");
                    if (option == 'Y')
                    {

                        _User.Cart.Romove(_User.Cart.Items.Count() - 1);

                        Console.WriteLine("Removed Successfully ");
                    }
                    else
                    {
                        Console.WriteLine("Cancelled  ");
                    }
                }
            }
            else
            {
                Console.WriteLine("There is no Operation");
            }

        }

        public void Show_Menu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("[1] Products");
            Console.WriteLine("[2] View Cart");
            Console.WriteLine("[3] Add Item To cart ");
            Console.WriteLine("[4] Remove Item From Cart");
            Console.WriteLine("[5] Undo Last Operation");
            Console.WriteLine("[6] Check Out");
            Console.WriteLine("[7] Exit");
            Console.WriteLine("-----------------------------------");
            Console.Write("Enter Your Option : ");

        }
    }
}
