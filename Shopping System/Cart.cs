using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Cart
    {
        private List<Item> _items;
        public Cart()
        {
            _items = new List<Item>();
        }
        public List<Item> Items { set { _items = value; } get { return _items; } }
        public void Additem(Item item)
        {
            _items.Add(item);
        }

        public void Romove(int index)
        {
            _items.RemoveAt(index);
        }


    }
}
