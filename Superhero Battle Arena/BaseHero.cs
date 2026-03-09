using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Superhero_Battle_Arena
{
    internal abstract class BaseHero
    {
        private int _power;
        private int _health;
        private string _name;
        public BaseHero(string name,int power, int health)
        {
            _power = power;
            _health = health;
            _name = name;
        }
        public int Power
        {
            set
            {
                if (value < 0)
                {
                   _power = 0;
                }
                else
                {
                    _power = value;
                }
            }
            get { return _power; }
        }
        
        public int Health
        {
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    _health = value;
                }
            }
            get { return _health; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public abstract void Attack(BaseHero enemy);
        
        public  void Introduce()
        {
            Console.WriteLine($"Name : {_name} | Power :  {_power} | Heath : {_health}");
        }
        public void Heal()
        { 
            Heal(20);
        }
        public void Heal(int amount)
        {
            Random r = new Random();
            //Getting Extra Damege with Possiablity of 1/10
            if (r.Next(0, 10) == 0)
            {
                Console.WriteLine("More Heath !!");
                amount *= 5;
            }
            Health += amount;
            Console.WriteLine($" {_name} healed {amount}  ");
        }
        public void Conditions()
        {
            Console.WriteLine($"Name : {_name} | Heath : {_health}");
        }
        public bool IsAlive()
        {
            return _health > 0;
        }


    }
}
