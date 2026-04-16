using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class User
    {
        private string _name;

        private double _Balance;
        private Cart _cart;
        public User(string name, double balance, Cart cart)
        {
            _name = name;
            _Balance = balance;
            _cart = cart;
        }
        public double Balance
        {
            set
            {
                if (value < 0)
                    value = 0;
                _Balance = value;
            }
            get { return _Balance; }

        }
        public string Name { set { _name = value; } get { return _name; } }
        public Cart Cart { set { _cart = value; } get { return _cart; } }

    }
}
