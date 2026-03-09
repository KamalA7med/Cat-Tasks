using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Superhero_Battle_Arena
{
    internal class Archer:BaseHero
    {
        public Archer(string name, int power, int health) : base(name, power, health)
        {

        }

        public override void Attack(BaseHero enemy)
        {
            int Damage = Power;
            Random r = new Random();
            //Getting Extra Damege with Possiablity of 1/5
            if (r.Next(0, 5) == 0)
            {
                Console.WriteLine("Over Damage !!");
                Damage *= 2;
            }
            enemy.Health -= Damage;
            Console.WriteLine($"{Name} throws an arrow on {enemy.Name} for {Damage} damage!");
        }
    }
}
