using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            bool fighting = false;
            bool inShop = false;
            string command;
            

            Console.WriteLine("\n_______Welcome to the most epic adventure on Earth._______\n\nWhat be your name, squire!\n");
            Console.Write("Enter Name: ");
            Player player = new Player(Console.ReadLine());
            Console.WriteLine("\nHark, {0}, first entrant to the most epic adventure on earth!\n", player.GetName());

            Enemy[] enemies = new Enemy[10];
            enemies[9] = new Enemy("Fruit Fly", 1, 1);
            enemies[8] = new Enemy("Burger With Legs", 10, 5);
            enemies[7] = new Enemy("Highly Energetic Spade", 20, 10);
            enemies[6] = new Enemy("Failed Gang Member", 30, 20);
            enemies[5] = new Enemy("Deadly Nettle Cluster", 40, 30);
            enemies[4] = new Enemy("Doom Turnip", 50, 40);
            enemies[3] = new Enemy("Angry E.T.", 60, 50);
            enemies[2] = new Enemy("Bermuda Triangle", 70, 60);
            enemies[1] = new Enemy("Loneley Panzer Tank", 80, 70);
            enemies[0] = new Enemy("God On Acid", 90, 80);

            

            while (playing)
            {
                int battleNum = 0;
                Console.WriteLine("___________________________________");
                Console.Write("Type 'help' for available commands\nEnter command: ");
                command = Console.ReadLine().ToLower();
                Console.WriteLine("___________________________________");

                switch (command)
                {
                    default:
                        Console.WriteLine("What is this bollocks you're talking about, {0}!", player.GetName());
                        break;
                    case "battle":
                        battleNum = player.GetBattleNumber();                        
                        enemies[battleNum].Create();
                        fighting = true;
                        break;
                    case "add ammo":
                        if (player.playerInventory.ammo.GetAmount() == 0)
                        {
                            Console.WriteLine("\nNo ammo left!\n");
                            break;
                        }
                        else
                            player.Use("ammo");
                        break;

                    case "use health":
                        if (player.playerInventory.health.GetAmount() == 0)
                        {
                            Console.WriteLine("\nNo health pills left!\n");
                            break;
                        }
                        else
                            player.Use("health");
                        break;
                    case "equip fork":
                        player.Equip("fork");
                        break;
                    case "equip antler":
                        player.Equip("antler");
                        break;
                    case "equip poison spear":
                        player.Equip("poison spear");
                        break;
                    case "equip spear":
                        player.Equip("spear");
                        break;
                    case "equip sludge pistol":
                        player.Equip("sludge pistol");
                        break;
                    case "equip toxic sludge pistol":
                        player.Equip("toxic sludge pistol");
                        break;
                    case "equip pistol":
                        player.Equip("pistol");
                        break;
                    case "equip gutting machine":
                        player.Equip("gutting machine");
                        break;
                    case "equip gut machine":
                        player.Equip("gut machine");
                        break;
                    case "equip battleship cannon":
                        player.Equip("battleship cannon");
                        break;
                    case "equip battleship":
                        player.Equip("battleship");
                        break;
                    case "equip cannon":
                        player.Equip("cannon");
                        break;
                    case "equip ship":
                        player.Equip("ship");
                        break;
                    case "weapon info":
                        player.selectedWeapon.WeaponInfo();
                        break;
                    case "player info":
                        player.ViewPlayerStats();
                        break;
                    case "inventory":
                        player.playerInventory.InventoryInfo();
                        break;
                    case "shop":
                        Console.WriteLine("\nYou have entered the shop, feeble {0}.", player.GetName());
                        inShop = true;
                        break;
                    case "game info":
                        Console.WriteLine("\n_______WELCOME TO THE MOST EPIC ADVENTURE ON EARTH_____\n");
                        Console.WriteLine("This is a basic text-based game, where the user inputs various commands\n" +
                            "in order to complete battles, buy items and make further progress. The aim\n" +
                            "is to earn enough money to afford all the available weapons in the shop, \n" +
                            "after which point it should be possible to easily defeat all enemies in combat.\n" +
                            "There are ten types of enemy in total. The most difficult enemies are\n" +
                            "encountered less often on the battlefield. Some are extremely rare.\n" +
                            "Hint: Check enemy info before attacking.\n\n   Created in a day by Stuart Aitken\n");
                        break;
                    case "help":
                        Console.WriteLine("\n___Available Commands___");
                        Console.WriteLine("Battle: --------- Find battle!");
                        Console.WriteLine("Use health: ----- Use health pill.");
                        Console.WriteLine("Equip X: -------- Equip desired weapon.");
                        Console.WriteLine("Shop: ----------- Enter shop");
                        Console.WriteLine("Add ammo: ------- Add ammo to current weapon.");
                        Console.WriteLine("Player info: ---- View player info.");
                        Console.WriteLine("Weapon info: ---- View info for current weapon.");
                        Console.WriteLine("Inventory: ------ View inventory info.");
                        Console.WriteLine("Game info: ------ Display game information.");
                        Console.WriteLine("Quit / Exit: ---- Exit game.\n");
                        break;
                    case "quit":
                        playing = false;
                        break;
                    case "exit":
                        playing = false;
                        break;

                }

                while(inShop)
                {
                    Console.WriteLine("___________________________________");
                    Console.WriteLine("\n_____Available Items_____");
                    if (!player.playerInventory.antler.WeaponStatus())
                        Console.WriteLine("{0} : £{1}", player.playerInventory.antler.GetWeaponName(), player.playerInventory.antler.Getpower());
                    if (!player.playerInventory.poisonSpear.WeaponStatus())
                        Console.WriteLine("{0} : £{1}", player.playerInventory.poisonSpear.GetWeaponName(), player.playerInventory.poisonSpear.Getpower());
                    if (!player.playerInventory.toxicSludgePistol.WeaponStatus())
                        Console.WriteLine("{0} : £{1}", player.playerInventory.toxicSludgePistol.GetWeaponName(), player.playerInventory.toxicSludgePistol.Getpower());
                    if (!player.playerInventory.guttingMachine.WeaponStatus())
                        Console.WriteLine("{0} : £{1}", player.playerInventory.guttingMachine.GetWeaponName(), player.playerInventory.guttingMachine.Getpower());
                    if (!player.playerInventory.battleshipCannon.WeaponStatus())
                        Console.WriteLine("{0} : £{1}", player.playerInventory.battleshipCannon.GetWeaponName(), player.playerInventory.battleshipCannon.Getpower());
                    Console.WriteLine("Ammo : £{0}", player.playerInventory.ammo.GetCost());
                    Console.WriteLine("Health pill: £{0}", player.playerInventory.health.GetCost());
                    Console.WriteLine();
                    Console.WriteLine("Available funds: £{0}", player.playerInventory.money.GetAmount());
                    Console.WriteLine("Use 'buy' command to purchase\nType 'exit' to leave.\n");
                    Console.Write("Enter command: ");
                    command = Console.ReadLine().ToLower();
                    Console.WriteLine("___________________________________");

                    switch (command)
                    {
                        case "buy antler":
                            if (player.playerInventory.antler.WeaponStatus())
                            {
                                Console.WriteLine("\nYou already own this, you pathetic worm.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else if (player.playerInventory.money.GetAmount() < player.playerInventory.antler.Getpower())
                            {
                                Console.WriteLine("\nYou don't have enough money, you useless trilobyte.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.antler.SetAvailable();
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.antler.Getpower());
                                Console.WriteLine("\n{0} has been bought.", player.playerInventory.antler.GetWeaponName());
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "buy poison spear":
                            if (player.playerInventory.poisonSpear.WeaponStatus())
                            {
                                Console.WriteLine("\nYou already own this, you pathetic worm.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else if (player.playerInventory.money.GetAmount() < player.playerInventory.poisonSpear.Getpower())
                            {
                                Console.WriteLine("\nYou don't have enough money, you useless trilobyte.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.poisonSpear.SetAvailable();
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.poisonSpear.Getpower());
                                Console.WriteLine("\n{0} has been bought.", player.playerInventory.poisonSpear.GetWeaponName());
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "buy toxic sludge pistol":
                            if (player.playerInventory.toxicSludgePistol.WeaponStatus())
                            {
                                Console.WriteLine("\nYou already own this, you pathetic worm.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else if (player.playerInventory.money.GetAmount() < player.playerInventory.toxicSludgePistol.Getpower())
                            {
                                Console.WriteLine("\nYou don't have enough money, you useless trilobyte.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.toxicSludgePistol.SetAvailable();
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.toxicSludgePistol.Getpower());
                                Console.WriteLine("\n{0} has been bought.", player.playerInventory.toxicSludgePistol.GetWeaponName());
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "buy toxic gutting machine":
                            if (player.playerInventory.guttingMachine.WeaponStatus())
                            {
                                Console.WriteLine("\nYou already own this, you pathetic worm.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else if (player.playerInventory.money.GetAmount() < player.playerInventory.guttingMachine.Getpower())
                            {
                                Console.WriteLine("\nYou don't have enough money, you useless trilobyte.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.guttingMachine.SetAvailable();
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.guttingMachine.Getpower());
                                Console.WriteLine("\n{0} has been bought.", player.playerInventory.guttingMachine.GetWeaponName());
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "buy battleship cannon":
                            if (player.playerInventory.battleshipCannon.WeaponStatus())
                            {
                                Console.WriteLine("\nYou already own this, you pathetic worm.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else if (player.playerInventory.money.GetAmount() < player.playerInventory.battleshipCannon.Getpower())
                            {
                                Console.WriteLine("\nYou don't have enough money, you useless trilobyte.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.battleshipCannon.SetAvailable();
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.battleshipCannon.Getpower());
                                Console.WriteLine("\n{0} has been bought.", player.playerInventory.battleshipCannon.GetWeaponName());
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "buy health":
                            if (player.playerInventory.money.GetAmount() < player.playerInventory.health.GetCost())
                            {
                                Console.WriteLine("\nYou don't have enough money, you microbe.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.health.SetAmount(player.playerInventory.health.GetAmount()+1);
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.health.GetCost());
                                Console.WriteLine("\nOne health pill bought.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "buy ammo":
                            if (player.playerInventory.money.GetAmount() < player.playerInventory.ammo.GetCost())
                            {
                                Console.WriteLine("\nYou don't have enough money, you microbe.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.ammo.SetAmount(player.playerInventory.ammo.GetAmount() + 1);
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.ammo.GetCost());
                                Console.WriteLine("\nOne ammo bought.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "exit":
                            inShop = false;
                            break;
                    }
                }

                while(fighting)
                {

                    for (int i = 0; i < 10; i++)
                    {
                        if (enemies[i].Exists())
                        {
                            battleNum = i;
                            Console.WriteLine("___________________________________");
                            Console.WriteLine("A wild {0} is attacking you!", enemies[battleNum].GetName());
                            Console.WriteLine("Your health: {0}", player.GetHealth());
                            Console.WriteLine("Enemy health: {0}", enemies[i].GetHealth());
                        }
                    }

                    Console.Write("What will you do?!\nType 'help' for available commands\n");
                    Console.Write("Enter command: ");
                    command = Console.ReadLine().ToLower();
                    Console.WriteLine("___________________________________");


                    switch (command)
                    {
                       
                            default:
                                Console.WriteLine("\nStop talking nonsense, you're under attack!\n");
                                break;
                        case "attack":
                            if (player.selectedWeapon.UseWeapon())
                            {
                                enemies[battleNum].SetHealth(enemies[battleNum].GetHealth() - player.selectedWeapon.Getpower());
                                if (enemies[battleNum].GetHealth() <= 0)
                                {
                                    enemies[battleNum].SetHealth(0);
                                    Console.WriteLine("\n{0} died!", enemies[battleNum].GetName());
                                    player.SetPoints(player.GetPoints() + enemies[battleNum].GetAttackDamage());
                                    player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() + enemies[battleNum].GetAttackDamage());
                                    Console.WriteLine("{0} points gained!", enemies[battleNum].GetAttackDamage());
                                    Console.WriteLine("Dead {0} dropped £{1}!\n", enemies[battleNum].GetName(), enemies[battleNum].GetAttackDamage());
                                    Console.WriteLine("Current health: {0}", player.GetHealth());
                                    Console.WriteLine("Current points: {0}", player.GetPoints());
                                    Console.WriteLine("Current money: £{0}", player.playerInventory.money.GetAmount());
                                    Console.Write("Press enter to continue");
                                    Console.ReadLine();
                                    enemies[battleNum].Kill();
                                    fighting = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n{0} hit!", enemies[battleNum].GetName());
                                    Console.WriteLine("Enemy health: {0}", enemies[battleNum].GetHealth());
                                    Console.Write("Press enter to continue...\n");
                                    Console.ReadLine();
                                    Console.WriteLine("{0} hit you! Did {1} damage.", enemies[battleNum].GetName(), enemies[battleNum].GetAttackDamage());
                                    player.SetHealth(player.GetHealth() - enemies[battleNum].GetAttackDamage());
                                    if (player.GetHealth() < 0)
                                    {
                                        player.SetHealth(0);
                                        Console.WriteLine("\nYOU DIED!\n");
                                        fighting = false;
                                        playing = false;
                                        Console.Write("Press enter to continue...\n");
                                        Console.ReadLine();
                                        break;
                                    }
                                    Console.WriteLine("Current health: {0}\n", player.GetHealth());
                                    Console.Write("Press enter to continue...\n");
                                    Console.ReadLine();
                                    break;

                                }

                            }
                            else
                            {
                                Console.WriteLine("\nWhy did you attack?! You have no ammo!");
                                Console.WriteLine("{0} hit you! Did {1} damage.\n", enemies[battleNum].GetName(), enemies[battleNum].GetAttackDamage());
                                player.SetHealth(player.GetHealth() - enemies[battleNum].GetAttackDamage());
                                Console.Write("Press enter to continue...\n");
                                Console.ReadLine();
                                if (player.GetHealth() < 0)
                                {
                                    player.SetHealth(0);
                                    Console.WriteLine("YOU DIED!\n");
                                    fighting = false;
                                    playing = false;
                                    Console.WriteLine("Press enter to continue...\n");
                                    Console.ReadLine();
                                    break;
                                }
                                Console.WriteLine("Current health: {0}\n", player.GetHealth());
                                Console.WriteLine("Press enter to continue...\n");
                                Console.ReadLine();
                                break;
                            }
                                
                        case "add ammo":
                            if (player.playerInventory.ammo.GetAmount() == 0)
                            {
                                Console.WriteLine("\nNo ammo left!\n");
                                break;
                            }
                            else
                                player.Use("ammo");
                            break;
                    
                        case "use health":
                            if (player.playerInventory.health.GetAmount() == 0)
                            {
                                Console.WriteLine("\nNo health pills left!\n");
                                break;
                            }
                            else
                                player.Use("health");
                            break;
                        case "equip fork":
                            player.Equip("fork");
                            break;
                        case "equip antler":
                            player.Equip("antler");
                            break;
                        case "equip poison spear":
                            player.Equip("poison spear");
                            break;
                        case "equip spear":
                            player.Equip("spear");
                            break;
                        case "equip sludge pistol":
                            player.Equip("sludge pistol");
                            break;
                        case "equip toxic sludge pistol":
                            player.Equip("toxic sludge pistol");
                            break;
                        case "equip pistol":
                            player.Equip("pistol");
                            break;
                        case "equip gutting machine":
                            player.Equip("gutting machine");
                            break;
                        case "equip gut machine":
                            player.Equip("gut machine");
                            break;
                        case "equip battleship cannon":
                            player.Equip("battleship cannon");
                            break;
                        case "equip battleship":
                            player.Equip("battleship");
                            break;
                        case "equip cannon":
                            player.Equip("cannon");
                            break;
                        case "equip ship":
                            player.Equip("ship");
                            break;
                        case "flee":
                            Console.WriteLine("A pathetic escape!");
                            Console.WriteLine("You lose 10 points, feeble worm!\n");
                            player.SetPoints(player.GetPoints() - 10);
                            enemies[battleNum].Kill();
                            fighting = false;
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            break;

                        case "weapon info":
                            player.selectedWeapon.WeaponInfo();
                            break;
                        case "player info":
                            player.ViewPlayerStats();
                            break;
                        case "enemy info":
                            for (int i = 0; i < 10; i++)
                            {
                                if (enemies[i].Exists())
                                {
                                    enemies[i].EnemyInfo();
                                }
                            }
                            break;
                        case "inventory":
                            player.playerInventory.InventoryInfo();
                            break;

                        case "help":
                            Console.WriteLine("\n___Available Commands___");
                            Console.WriteLine("Attack: --------- Atack enemy using current weapon.");
                            Console.WriteLine("Use health: ----- Use health pill.");
                            Console.WriteLine("Equip X: -------- Equip desired weapon.");
                            Console.WriteLine("Add ammo: ------- Add ammo to current weapon.");
                            Console.WriteLine("Player info: ---- View player info.");
                            Console.WriteLine("Enemy info: ----- View enemy info.");
                            Console.WriteLine("Weapon info: ---- View info for current weapon.");
                            Console.WriteLine("Inventory: ------ View inventory info.");
                            Console.WriteLine("Flee: ----------- Escape.\n");
                            break;
                            

                    }

                }

            }

            Console.WriteLine("\nGAME OVER, MEAGRE SQUAB!\n");
            Console.WriteLine("Final Score: {0}", player.GetPoints());
            Console.WriteLine("Final money: £{0}\n", player.playerInventory.money.GetAmount());
            Console.WriteLine("Press enter to close.");
            Console.ReadLine();
        }
    }
}
