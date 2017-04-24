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
        public void SetName(string s)
        {
            name = s;
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
        public void CheckProgress(Inventory i, Enemy[] enemy)
        {
            double progress = 0;
            int cycle = 1;
            
            Console.WriteLine("\n_____ ENEMIES _____");
            for(int k = enemy.Length-1; k>-1;k--)
            {
                
                if (enemy[k].KilledOnce())
                {
                    Console.WriteLine("{0}. {1}: DEFEATED", cycle, enemy[k].GetName());
                    progress++;
                }
                else if(enemy[k].CheckSeenOnce())
                {
                    Console.WriteLine("{0}. {1}: FLED", cycle, enemy[k].GetName());
                }
                else
                    Console.WriteLine("{0}: UNKNOWN", cycle);
                cycle++;
                
                
            }
            progress += i.CheckProgressInvetory();
            progress = (progress / 16.0) * 100.0;
            Console.WriteLine("_____ GAME PROGRESS : {0}% _____", progress);
            Console.WriteLine();
        }
        public void SaveGame(Inventory i, Enemy[] enemy, string s)
        {
            List<string> data = new List<string>();
            //Player info
            data.Add(GetName());
            data.Add(GetHealth().ToString());
            data.Add(selectedWeapon.GetWeaponName());
            data.Add(GetPoints().ToString());
            //Inventory info
            data.Add(playerInventory.money.GetAmount().ToString());
            data.Add(playerInventory.ammo.GetAmount().ToString());
            data.Add(playerInventory.health.GetAmount().ToString());
            //Weapon info
            i.fork.SaveInfo(ref data);
            i.antler.SaveInfo(ref data);
            i.poisonSpear.SaveInfo(ref data);
            i.toxicSludgePistol.SaveInfo(ref data);
            i.guttingMachine.SaveInfo(ref data);
            i.battleshipCannon.SaveInfo(ref data);
            //Enemy info
            foreach(Enemy e in enemy)
            {
                e.SaveData(ref data);
            }
            //Save to file
            string directory = System.IO.Directory.GetCurrentDirectory();
            directory = directory + "\\" + s + ".txt";
            if (System.IO.File.Exists(directory))
            {
                Console.Write("File already exists! Overwrite? (Y/N): ");
                string overwrite = Console.ReadLine().ToLower();
                switch (overwrite)
                {
                    case "y":
                        System.IO.StreamWriter file = new System.IO.StreamWriter(directory);

                        foreach (var t in data)
                        {
                            file.WriteLine(t);
                        }
                        file.Close();
                        break;
                    case "n":
                        Console.WriteLine("Save aborted");
                        break;
                }
            }
            else
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(directory);
                foreach (var t in data)
                {
                    file.WriteLine(t);
                }
                file.Close();
            }
            Console.Write("Game saved. Press enter to continue...");
            Console.ReadLine();
        }

        public void LoadGame(ref Inventory i, ref Enemy[] enemy, string s)
        {
            List<string> data = new List<string>();
            string directory = System.IO.Directory.GetCurrentDirectory();
            directory = directory + "\\" + s + ".txt";

            if (!System.IO.File.Exists(directory))
                Console.WriteLine("File not found!");
            else
            {
                System.IO.StreamReader file = new System.IO.StreamReader(directory);
                data = System.IO.File.ReadAllLines(directory).ToList();


                //Player info
                SetName(data[0]);
                SetHealth(int.Parse(data[1]));
                selectedWeapon.SetWeaponName(data[2]);
                SetPoints(int.Parse(data[3]));
                //Inventory info
                playerInventory.money.SetAmount(int.Parse(data[4]));
                playerInventory.ammo.SetAmount(int.Parse(data[5]));
                playerInventory.health.SetAmount(int.Parse(data[6]));

                //Weapon info
                i.fork.LoadInfo(data[7], data[8], data[9]);
                i.antler.LoadInfo(data[10], data[11], data[12]);
                i.poisonSpear.LoadInfo(data[13], data[14], data[15]);
                i.toxicSludgePistol.LoadInfo(data[16], data[17], data[18]);
                i.guttingMachine.LoadInfo(data[19], data[20], data[21]);
                i.battleshipCannon.LoadInfo(data[22], data[23], data[24]);
                Equip(selectedWeapon.GetWeaponName());
                //Enemy info
                int j = 25;
                for (int k = 0; k < 10; k++)
                {
                    enemy[k].LoadData(data[j], data[j + 1], data[j + 2]);
                    j += 3;
                }

                file.Close();
                Console.WriteLine("_____ Game Loaded _____");
                ViewPlayerStats();
            }
            
        }

        
    }

}
