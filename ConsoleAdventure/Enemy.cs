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
        protected bool killedOnce;
        protected bool seenOnce;
        

        public Enemy(string name, int health, int attackDamage)
        {
            this.name = name;
            this.health = health;
            resetHealth = health;
            this.attackDamage = attackDamage;
            exists = false;
            killedOnce = false;
            seenOnce = false;
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
        public void CheckFirstKill()
        {
            if (killedOnce == false)
                killedOnce = true;
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
        public bool KilledOnce()
        {
            return killedOnce;
        }
        public void SeenOnce()
        {
            seenOnce = true;
        }
        public bool CheckSeenOnce()
        {
            return seenOnce;
        }

        public void SaveData(ref List<string> data)
        {
            data.Add(Exists().ToString());
            data.Add(KilledOnce().ToString());
            data.Add(CheckSeenOnce().ToString());
        }
        public void LoadData(string s, string t, string u)
        {
            exists = bool.Parse(s);
            killedOnce = bool.Parse(t);
            seenOnce = bool.Parse(u);
        }

        
    }
}
