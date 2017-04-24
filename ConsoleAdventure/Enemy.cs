using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    class Enemy
    {
        protected string name;
        protected int health;
        protected int attackDamage;
        protected int resetHealth;
        protected bool exists;
        

        public Enemy(string name, int health, int attackDamage)
        {
            this.name = name;
            this.health = health;
            resetHealth = health;
            this.attackDamage = attackDamage;
            exists = false;
        }

        public string GetName()
        {
            return name;
        }
        public void SetHealth(int set)
        {
            health = set;
        }
        public int GetHealth()
        {
            return health;
        }
        public int GetAttackDamage()
        {
            return attackDamage;
        }
        public void Create()
        {
            exists = true;
        }
        public void Kill()
        {
            exists = false;
            health = resetHealth;
        }
        public bool Exists()
        {
            return exists;
        }
        public void EnemyInfo()
        {
            Console.WriteLine("\nName: {0}", name);
            Console.WriteLine("Health: {0}", health);
            Console.WriteLine("Attack damage: {0}\n", attackDamage);
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        
    }
}
