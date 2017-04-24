using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    //Fields
    class Player
    {
        public Inventory playerInventory = new Inventory();
        private string name;
        private int health;
        private int money;
        private int points;

        public Weapon selectedWeapon;
        //Location location = new Location....?

        public Player(string name)
        {
            this.name = name;
            health = 100;
            money = 0;
            selectedWeapon = playerInventory.fork;
            points = 0;
        }

        public void Equip(string weapon)
        {
            weapon = weapon.ToLower();
            switch(weapon)
            {
                default:
                    Console.WriteLine("No weapon specified.\n");
                    break;
                case "fork":
                    selectedWeapon = playerInventory.fork;
                    break;
                case "antler":
                    if(!playerInventory.antler.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.antler;
                    break;
                case "poison spear":
                    if (!playerInventory.poisonSpear.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.poisonSpear;
                    break;
                case "spear":
                    if (!playerInventory.poisonSpear.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.poisonSpear;
                    break;
                case "sludge pistol":
                    if (!playerInventory.toxicSludgePistol.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.toxicSludgePistol;
                    break;
                case "toxic sludge pistol":
                    if (!playerInventory.toxicSludgePistol.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.toxicSludgePistol;
                    break;
                case "pistol":
                    if (!playerInventory.toxicSludgePistol.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.toxicSludgePistol;
                    break;
                case "gutting machine":
                    if (!playerInventory.guttingMachine.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.guttingMachine;
                    break;
                case "gut machine":
                    if (!playerInventory.guttingMachine.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.guttingMachine;
                    break;
                case "battleship cannon":
                    if (!playerInventory.battleshipCannon.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.battleshipCannon;
                    break;
                case "battleship":
                    if (!playerInventory.battleshipCannon.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.battleshipCannon;
                    break;
                case "cannon":
                    if (!playerInventory.battleshipCannon.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.battleshipCannon;
                    break;
                case "ship":
                    if (!playerInventory.battleshipCannon.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.battleshipCannon;
                    break;
            }
            Console.WriteLine("{0} is eqipped.\n",selectedWeapon.GetWeaponName());
                
            
        }
        public void Use(string item)
        {
            item = item.ToLower();
            switch(item)
            {
                default:
                    Console.WriteLine("No item specified.\n");
                    break;
                case "health":
                    if (health == 100)
                    {
                        Console.WriteLine("Health already full.\n");
                    }
                    else
                    {
                        playerInventory.health.Use();
                        health += 20;
                        if (health > 100)
                            health = 100;
                        Console.WriteLine("Health increased to {0}.\n", health);
                    }
                    break;
                case "ammo":
                    if ((selectedWeapon.GetWeaponName() != "Toxic Sludge Pistol") && selectedWeapon.GetWeaponName() != "Battleship Cannon")
                    {
                        Console.WriteLine("This weapon does not need ammo.\n");
                        break;
                    }
                    else
                    {
                        int ammoAdd = 0;
                        Console.WriteLine("How much ammo would you like to add?");
                        Console.WriteLine("Current weapon ammo: {0}", selectedWeapon.GetWeaponAmmo());
                        Console.WriteLine("Available ammo: {0}", playerInventory.ammo.GetAmount());
                        Console.WriteLine("(One shot of this weapon requires at least {1} ammo)", selectedWeapon.GetWeaponName(), selectedWeapon.Getpower() );
                        Console.Write("Enter value: ");
                        string input = Console.ReadLine().ToLower();
                        if (!int.TryParse(input, out ammoAdd))
                        {
                            Console.WriteLine("Non-numerical value entered.");
                            break;
                        }
                        selectedWeapon.AddAmmo(ammoAdd);
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                    }
                        
                    break;
            }
        }
        public string GetName()
        {
            return name;
        }
        public void ViewPlayerStats()
        {
            money = playerInventory.money.GetAmount();

            Console.WriteLine("\nName: {0}", name);
            Console.WriteLine("Current health: {0}", health);
            Console.WriteLine("Money: £{0}", money);
            Console.WriteLine("Equipped weapon: {0}", selectedWeapon.GetWeaponName());
            Console.WriteLine("Weapon ammo: {0}", selectedWeapon.GetWeaponAmmo());
            Console.WriteLine("Inventory ammo: {0}", selectedWeapon.GetWeaponAmmo());
            Console.WriteLine("Total points: {0}\n", points);
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }
        public void ViewWeapongStatus()
        {
            selectedWeapon.WeaponStatus();
        }
        public void CheckMoney()
        {
            money = playerInventory.money.GetAmount();
            Console.WriteLine("You have £{0}.\n", money);
        }
        public int GetBattleNumber()
        {
            Random rand = new Random(DateTime.Now.Second);
            double num = rand.Next(0, 99);
            num = Math.Round(Math.Sqrt(num));
            if (num == 10)
                num = 9;
            return (int)num;
        }
        public void SetPoints(int points)
        {
            this.points = points;
        }
        public int GetPoints()
        {
            return points;
        }
        public void SetHealth(int health)
        {
            this.health = health;
        }
        public int GetHealth()
        {
            return health;
        }
        
    }

}
