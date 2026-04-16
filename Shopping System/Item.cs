using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Item
    {
        private string _name;
        private int _price;
        private string _description;
        private int _quantity;
        public Item(string name, int price, string description, int quantity)
        {
            _name = name;
            _price = price;
            _description = description;
            _quantity = quantity;
        }
        public string Name { set { _name = value; } get { return _name; } }
        public int Price
        {
            set
            {
                if (value < 0)
                    value = 0;
                _price = value;
            }
            get { return _price; }
        }
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        public int Qunatity
        {
            set
            {
                if (value < 0)
                    value = 0;
                _quantity = value;
            }
            get { return _quantity; }
        }
    }
}
