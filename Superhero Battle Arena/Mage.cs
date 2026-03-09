using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Battle_Arena
{
    internal class Mage:BaseHero
    {
        public Mage(string name, int power, int health) : base(name, power, health)
        {

        }
      
        public override void Attack(BaseHero enemy)
        {
            int Damage = Power;
            Random r = new Random();
            //Getting Extra Damege with Possiablity of 1/4
            if (r.Next(0, 4) == 0)
            {
                Console.WriteLine("Over Damage !!");
                Damage *= 2;
            }
            enemy.Health -= Damage;
            Console.WriteLine($"{Name} burns {enemy.Name} for {Damage} damage !");
        }
    }
}
