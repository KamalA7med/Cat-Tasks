using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Battle_Arena
{
    internal class Game
    {
       
        public Game() { }
        private List<BaseHero> Get_Characters()
        {
            List<BaseHero>characters = new List<BaseHero>();
            BaseHero warrior = new Warrior("Thor",25,200);
           
            BaseHero archer = new Archer("Kamal",30,150);
     
            BaseHero mage = new Mage("Randy Orten",35,100);  
            characters.Add(warrior);
            characters.Add(archer);
            characters.Add(mage);
            return characters;
        }
        private void Print_Characters(List<BaseHero> characters)
        {
            int i = 1;
            foreach (var character in characters)
            {
                Console.Write($"{i} : ");
                character.Introduce();
                i++;
            }
                
        }
        private BaseHero GetRandomEnemy(List<BaseHero>characters,int PlayerIndex)
            {
            int enemyIndex = PlayerIndex;
            Random r= new Random();
            while (enemyIndex == PlayerIndex)
            {
                enemyIndex = r.Next(0,characters.Count);
            }
            return characters[enemyIndex];

            }
        private void GetPlayerAction(BaseHero Player,BaseHero enemy)
        {
            Console.WriteLine("[1] Attack");
            Console.WriteLine("[2] Heal");
            Console.WriteLine("--------------------");
            Console.Write("Enter Your Action :");
            int choice=int.Parse(Console.ReadLine());
            if (choice == 1)
                Player.Attack(enemy);
            else
                Player.Heal();
        }
        private void GetEnemyAction(BaseHero Player, BaseHero enemy)
        {
            Random r= new Random();

            int choice = r.Next(1,3);
            if (choice == 1)
                enemy.Attack(Player);
            else
                enemy.Heal();
        }

        public void StartGame()
        {
            List<BaseHero>characters= Get_Characters();
            Print_Characters(characters);
            Console.WriteLine("-------------------------");
            Console.Write("Enter Choice : ");
            int choice =int.Parse(Console.ReadLine());
            BaseHero player = characters[choice-1];
            BaseHero enemy = GetRandomEnemy(characters, choice - 1);
            while (true)
            {

               Console.Clear();
                GetPlayerAction(player, enemy);
                if (!enemy.IsAlive())
                {
                    Console.WriteLine("\n\n--------------------------");
                    Console.WriteLine("You Won The Battle");
                    Console.WriteLine("--------------------------");
                    break;
                }
                GetEnemyAction(player, enemy);
                
                if (!player.IsAlive())
                {
                    Console.WriteLine("\n\n--------------------------");
                    Console.WriteLine("   You Lost The Battle");
                    Console.WriteLine("--------------------------");

                    break;
                }
                Console.WriteLine();
                player.Conditions();
                enemy.Conditions();
                Console.WriteLine("Enter any Key To start the next round....");
                Console.ReadKey();
            }
        }
    }
}
