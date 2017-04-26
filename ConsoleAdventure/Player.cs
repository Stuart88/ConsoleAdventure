using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    
    class Player
    {
        public Inventory playerInventory = new Inventory();
        
        private string name;
        private int health;
        private int money;
        private int points;
        public double progress;
        public bool gameComplete;


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
                case "anti-god gun":
                    if (!playerInventory.antiGodGun.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.antiGodGun;
                    break;

            }
            Console.WriteLine("{0} is eqipped.\n",selectedWeapon.GetWeaponName());
            Console.Write("Press enter to continue...");
            Console.ReadLine();
                
            
        }
        public void Equip2(string weapon) // For equpping when loading game (has no 'you have equipped..' prompt)
        {
            weapon = weapon.ToLower();
            switch (weapon)
            {
                default:
                    Console.WriteLine("No weapon specified.\n");
                    break;
                case "fork":
                    selectedWeapon = playerInventory.fork;
                    break;
                case "antler":
                    if (!playerInventory.antler.WeaponStatus())
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
                case "anti-god gun":
                    if (!playerInventory.antiGodGun.WeaponStatus())
                    {
                        Console.WriteLine("\nYou do not have this weapon yet.\n");
                    }
                    else
                        selectedWeapon = playerInventory.antiGodGun;
                    break;
                
            }
            


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
                        Console.Write("Press enter to continue...");
                        Console.ReadLine();
                    }
                    else
                    {
                        playerInventory.health.Use();
                        health += 20;
                        if (health > 100)
                            health = 100;
                        Console.WriteLine("Health increased to {0}.\n", health);
                        if(health == 100)
                            Console.WriteLine("Health full.\n");
                        Console.Write("Press enter to continue...");
                        Console.ReadLine();
                    }
                    break;
                case "ammo":
                    if ((selectedWeapon.GetWeaponName() != "Toxic Sludge Pistol") && selectedWeapon.GetWeaponName() != "Anti-God Gun")
                    {
                        Console.WriteLine("This weapon does not need ammo.\n");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        int ammoAdd = 0;
                        Console.WriteLine("How much ammo would you like to add?");
                        Console.WriteLine("Current weapon ammo: {0}", selectedWeapon.GetWeaponAmmo());
                        Console.WriteLine("Available ammo: {0}", playerInventory.ammo.GetAmount());
                        Console.WriteLine("(One shot of this weapon requires at least {0} ammo)", selectedWeapon.Getpower() );
                        Console.Write("Enter value: ");
                        string input = Console.ReadLine().ToLower();
                        if (!int.TryParse(input, out ammoAdd))
                        {
                            Console.WriteLine("Non-numerical value entered.");
                            break;
                        }
                        selectedWeapon.AddAmmo(playerInventory, ammoAdd);
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
            Console.WriteLine("Health pills: {0}", playerInventory.health.GetAmount());
            Console.WriteLine("\nEquipped weapon: {0}", selectedWeapon.GetWeaponName());
            Console.WriteLine("Weapon ammo: {0}", selectedWeapon.GetWeaponAmmo());
            Console.WriteLine("Inventory ammo: {0}", selectedWeapon.GetWeaponAmmo());
            Console.WriteLine("\nTotal points: {0}", points);
            Console.WriteLine("Money: £{0}\n", money);
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
            double num;
            Random rand = new Random(DateTime.Now.Second);
            if (progress>80)
            {
                
                num = rand.Next(10);
            }
            else
            {
                progress = (progress / 10);
                num = (9 - rand.Next((int)Math.Round(progress) + 1));
            }
            
            if (num < 0)
                num = 0;
            if (num > 9)
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
        public void UpdateProgress(Inventory i, Enemy[] enemy)
        {
            double progress = 0;
            int cycle = 1;
            for (int k = enemy.Length - 1; k > -1; k--)
            {

                if (enemy[k].KilledOnce())
                {
                    progress++;
                }
                
                cycle++;


            }
            progress += i.UpdateProgressInvetory();
            progress = (progress / 16.0) * 100.0;
            this.progress = progress;
            if (progress == 100)
                gameComplete = true;
            
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
            this.progress = progress;
            Console.WriteLine("_____ GAME PROGRESS : {0}% _____", progress);
            Console.WriteLine();
            if(progress == 100)
            {
                Console.WriteLine("Congratulations, weakling, you've completed the game!");
                Console.WriteLine("You can now use the 'fight' command to pick a battle with any enemy\n");
            }
            Console.Write("Press enter to continue...");
            Console.ReadLine();
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
            i.antiGodGun.SaveInfo(ref data);
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
                bool saving = true;
                while(saving)
                {
                    Console.Write("File already exists! Overwrite? (Y/N): ");
                    string overwrite = Console.ReadLine().ToLower();
                    switch (overwrite)
                    {
                        case "y":
                        case "yes":
                            System.IO.StreamWriter file = new System.IO.StreamWriter(directory);

                            foreach (var t in data)
                            {
                                file.WriteLine(t);
                            }
                            file.Write("ConsoleAdventure666");
                            Console.WriteLine("Game saved to local directory.");
                            file.Close();
                            saving = false;
                            break;
                        case "n":
                        case "no":
                            Console.WriteLine("Save aborted");
                            saving = false;
                            break;
                    }
                }
                
            }
            else
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(directory);
                foreach (var t in data)
                {
                    file.WriteLine(t);
                }
                file.Write("ConsoleAdventure666");
                Console.WriteLine("Game saved to local directory.");

                file.Close();
            }


 
        }

        public void LoadGame(ref Inventory i, ref Enemy[] enemy, string s, ref bool gamestart)
        {
            List<string> data = new List<string>();
            string directory = System.IO.Directory.GetCurrentDirectory();
            directory = directory + "\\" + s + ".txt";

            if (!System.IO.File.Exists(directory))
            {
                Console.WriteLine("File not found!\n");
                Console.Write("Press enter to continue...");
                Console.ReadLine();
                gamestart = true;
            }
            else
            {
                System.IO.StreamReader file = new System.IO.StreamReader(directory);
                data = System.IO.File.ReadAllLines(directory).ToList();
                if (data.Count != 56)
                {
                    Console.WriteLine("Loadfile corrupt. Aborted\n");
                    Console.Write("Press enter to continue...");
                    Console.ReadLine();
                    gamestart = true;
                }
                else if (data[55] != "ConsoleAdventure666")
                {
                    Console.WriteLine("Load file corrupt. Aborted\n");
                    Console.Write("Press enter to continue...");
                    Console.ReadLine();
                    gamestart = true;
                }
                else
                {

                    //Player info
                    SetName(data[0]);
                    SetHealth(int.Parse(data[1]));

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
                    i.antiGodGun.LoadInfo(data[22], data[23], data[24]);



                    //Enemy info
                    int j = 25;
                    for (int k = 0; k < 10; k++)
                    {
                        enemy[k].LoadData(data[j], data[j + 1], data[j + 2]);
                        j += 3;
                    }
                    //Do this last (can only use 'Equip2' method after all weapon availability stats have been loaded
                    Equip2(data[2]);
                    selectedWeapon.SetWeaponName(data[2]);

                    UpdateProgress(i, enemy);

                    file.Close();
                    Console.WriteLine("\n_____ Game Loaded _____");
                    ViewPlayerStats();
                }



            }
            
        }

        
    }

}
