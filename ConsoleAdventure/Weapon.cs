using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    class Weapon
    {
        protected string name;
        protected int power;
        protected int ammo;
        protected bool available;
        protected bool selected;

        public Weapon(string name, int power)
            : this(name, power, 0, false, false) { }
        public Weapon(string name, int power, int ammo, bool available, bool selected)
        {
            this.name = name;
            this.power = power;
            this.available = available;
            this.selected = selected;
        }

        public string GetWeaponName()
        {
            return name;
        }
        public int GetWeaponAmmo()
        {
            return ammo;
        }
        public bool UseWeapon()
        {
            if (ammo < power && (name == "Toxic Sludge Pistol" || name == "Battleship Cannon"))
            {
                Console.WriteLine("Not enough ammo!\n");
                return false;
            }
            else
            {
                if(name == "Toxic Sludge Pistol" || name == "Battleship Cannon")
                    ammo -= power;
                return true;
            }
        }
        public int Getpower()
        {
            return power;
        }
        public void SetAvailable()
        {
            available = true;
        }
        public void SelectWeapon()
        {
            selected = true; 
        }
        public void AddAmmo(int ammo)
        {
            if (name == "Fork")
            {
                Console.WriteLine("Forks don't use ammo. Equip another weapon.\n");
            }
            else
            {
                this.ammo += ammo;
                Console.WriteLine("{0} ammo increased to {1}\n", name, ammo);
            }
        }
        public bool WeaponStatus()
        {
            return available;
        }
        public void WeaponInfo()
        {
            Console.WriteLine("\nCurrent weapon: {0}", name);
            Console.WriteLine("Weapon power: {0}\n", power);
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
