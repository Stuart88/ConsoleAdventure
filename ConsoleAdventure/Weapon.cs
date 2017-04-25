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
        public bool selected;

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
        public void SetWeaponName(string s)
        {
            name = s;
        }
        public int GetWeaponAmmo()
        {
            return ammo;
        }
        public void SetWeaponAmmo(int set)
        {
            ammo = set;
        }
        public bool UseWeapon()
        {
            if (ammo < power && (name == "Toxic Sludge Pistol" || name == "Anti-God Gun"))
            {
                return false;
            }
            else
            {
                if(name == "Toxic Sludge Pistol" || name == "Anti-God Gun")
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
        public void AddAmmo(Inventory i, int ammo)
        {
            if (name == "Fork")
            {
                Console.WriteLine("Forks don't use ammo. Equip another weapon.\n");
            }
            else
            {
                this.ammo += ammo;
                i.ammo.SetAmount(i.ammo.GetAmount() - ammo);
                Console.WriteLine("{0} ammo increased to {1}\n", GetWeaponName(), GetWeaponAmmo());
            }
        }
        public void SetWeaponStatus(bool set)
        {
            available= set;
        }
        public bool WeaponStatus()
        {
            return available;
        }
        public void WeaponInfo()
        {
            Console.WriteLine("\nCurrent weapon: {0}", GetWeaponName());
            Console.WriteLine("Weapon power: {0}", Getpower());
            Console.WriteLine("Weapon ammo: {0}\n", GetWeaponAmmo());
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }
        
        public void SaveInfo(ref List<string> data)
        {
            data.Add(GetWeaponAmmo().ToString());
            data.Add(WeaponStatus().ToString());
            data.Add(available.ToString());
        }
        public void LoadInfo(string s, string t, string u)
        {
            SetWeaponAmmo(int.Parse(s));
            SetWeaponStatus(bool.Parse(t));
            selected = bool.Parse(u);
        }

        public void Reset()
        {
            available = false;
            ammo = 0;
            selected = false;
        }
    }
}
