using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Notification_System
{
    internal class Order
    {
        private double _price;
        private int _id;
        public  int Id
        {
            get { return _id; }
            set
            {
                if (value < 0)
                 throw new ArgumentOutOfRangeException("value");
                //we can not guess which id to give to that order so throw exception is a better way than iving it an id
                _id = value;
            }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0) 
                    value = 0;
              _price = value;
            }
        }
        public Order(int id,  string name,double Price, string description)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("value");
            _id = id;
            Name = name;
            Description = description;
            if (Price < 0)
                Price = 0;
            _price = Price;
        }

    }
}
