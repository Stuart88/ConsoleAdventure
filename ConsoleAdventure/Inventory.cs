using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    class Inventory
    {
        public Weapon fork = new Weapon("Fork", 5, 1, true, true);
        public Weapon antler = new Weapon("Antler", 15, 1, false, false);
        public Weapon poisonSpear = new Weapon("Poison Spear", 40, 1, false, false);
        public Weapon toxicSludgePistol = new Weapon("Toxic Sludge Pistol", 60, 0, false, false);
        public Weapon guttingMachine = new Weapon("Gutting Machine", 100, 1, false, false);
        public Weapon antiGodGun = new Weapon("Anti-God Gun", 100, 0, false, false);

        public Item health = new Item("Health", 10, 0, 20);
        public Item ammo = new Item("Ammo", 1, 0, 1);
        public Item money = new Item("Money", 1, 0, 1);

        public void InventoryInfo()
        {
            Console.WriteLine("\nMoney: £{0}", money.GetAmount());
            Console.WriteLine("Available health pills: {0}", health.GetAmount());
            Console.WriteLine("Available weapons:");
            Console.WriteLine("               {0}", fork.GetWeaponName());
            if(antler.WeaponStatus())
                Console.WriteLine("               {0}", antler.GetWeaponName());
            if (poisonSpear.WeaponStatus())
                Console.WriteLine("               {0}", poisonSpear.GetWeaponName());
            if(toxicSludgePistol.WeaponStatus())
                Console.WriteLine("               {0}", toxicSludgePistol.GetWeaponName());
            if(guttingMachine.WeaponStatus())
                Console.WriteLine("               {0}", guttingMachine.GetWeaponName());
            if(antiGodGun.WeaponStatus())
                Console.WriteLine("               {0}", antiGodGun.GetWeaponName());
            Console.WriteLine("Available weapon ammo: {0}\n", ammo.GetAmount());
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        public float CheckProgressInvetory()
        {
            
            float count = 0;
            Console.WriteLine("\n_____ WEAPONS _____");
            if (fork.WeaponStatus())
                count++;
            if (antler.WeaponStatus())
                count++;
            if (poisonSpear.WeaponStatus())
                count++;
            if (toxicSludgePistol.WeaponStatus())
                count++;
            if (guttingMachine.WeaponStatus())
                count++;
            if (antiGodGun.WeaponStatus())
                count++;
            Console.WriteLine("{0}/6 weapons owned.\n", count);
            return count;
            
        }

        public float UpdateProgressInvetory()
        {

            float count = 0;

            if (fork.WeaponStatus())
                count++;
            if (antler.WeaponStatus())
                count++;
            if (poisonSpear.WeaponStatus())
                count++;
            if (toxicSludgePistol.WeaponStatus())
                count++;
            if (guttingMachine.WeaponStatus())
                count++;
            if (antiGodGun.WeaponStatus())
                count++;

            return count;

        }



    }
}
