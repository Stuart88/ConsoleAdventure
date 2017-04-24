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
        public Weapon guttingMachine = new Weapon("Gutting Machine", 80, 1, false, false);
        public Weapon battleshipCannon = new Weapon("Battleship Cannon", 100, 0, false, false);

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
            if(battleshipCannon.WeaponStatus())
                Console.WriteLine("               {0}", battleshipCannon.GetWeaponName());
            Console.WriteLine("Available weapon ammo: {0}\n", ammo.GetAmount());
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        

    }
}
