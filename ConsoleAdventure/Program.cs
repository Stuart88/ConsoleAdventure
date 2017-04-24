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
            enemies[5] = new Enemy("Deadly Nettle Cluster", 50, 30);
            enemies[4] = new Enemy("Doom Turnip", 100, 40);
            enemies[3] = new Enemy("Angry E.T.", 200, 50);
            enemies[2] = new Enemy("Bermuda Triangle", 300, 60);
            enemies[1] = new Enemy("Loneley Panzer Tank", 400, 70);
            enemies[0] = new Enemy("God On Acid", 500, 80);

            

            while (playing)
            {
                int battleNum = 0;
                Console.WriteLine("___________________________________");
                Console.Write("Type 'help' for available commands\nEnter command: ");
                command = Console.ReadLine().ToLower();
                Console.WriteLine("___________________________________");

                switch (command)
                {
                    
                    case "s":
                    case "save":
                        Console.Write("Enter save name (simple numbers are easiest to remember): ");
                        player.SaveGame(player.playerInventory, enemies, Console.ReadLine());
                        break;
                    case "l":
                    case "load":
                        Console.Write("Enter saved game name: ");
                        player.LoadGame(ref player.playerInventory, ref enemies, Console.ReadLine());
                        break;
                    case "b":
                    case "battle":
                        player.UpdateProgress(player.playerInventory, enemies);
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

                    case "health":
                    case "use health":
                        if (player.playerInventory.health.GetAmount() == 0)
                        {
                            Console.WriteLine("\nNo health pills left!\n");
                            break;
                        }
                        else
                            player.Use("health");
                        break;
                    case "1":
                    case "equip 1":
                    case "equip fork":
                        player.Equip("fork");
                        break;
                    case "2":
                    case "equip 2":
                    case "equip antler":
                        player.Equip("antler");
                        break;
                    case "3":
                    case "equip 3":
                    case "equip poison spear":
                        player.Equip("poison spear");
                        break;
                    case "equip spear":
                        player.Equip("spear");
                        break;
                    case "4":
                    case "equip 4":
                    case "equip sludge pistol":
                        player.Equip("sludge pistol");
                        break;
                    case "equip toxic sludge pistol":
                        player.Equip("toxic sludge pistol");
                        break;
                    case "equip pistol":
                        player.Equip("pistol");
                        break;
                    case "5":
                    case "equip 5":
                    case "equip gutting machine":
                        player.Equip("gutting machine");
                        break;
                    case "equip gut machine":
                        player.Equip("gut machine");
                        break;
                    case "6":
                    case "equip 6":
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
                    case "wi":
                    case "weapon":
                    case "weapon info":
                        player.selectedWeapon.WeaponInfo();
                        break;
                    case "pi":
                    case "player":
                    case "player info":
                        player.ViewPlayerStats();
                        break;
                    case "i":
                    case "inventory":
                        player.playerInventory.InventoryInfo();
                        break;
                    case "shop":
                        Console.WriteLine("\nYou have entered the shop, feeble {0}.", player.GetName());
                        inShop = true;
                        break;
                    case "gi":
                    case "game info":
                        Console.WriteLine("\n_______WELCOME TO THE MOST EPIC ADVENTURE ON EARTH_____\n");
                        Console.WriteLine("This is a basic text-based game, where the user inputs various commands\n" +
                            "in order to complete battles, buy items and make further progress. The aim\n" +
                            "is to earn enough money to afford all the available weapons in the shop, \n" +
                            "after which point it should be possible to easily defeat all enemies in combat.\n" +
                            "There are ten types of enemy in total. The most difficult enemies are\n" +
                            "encountered less often on the battlefield. Some are extremely rare.\n" +
                            "\n   Created in a day by Stuart Aitken\n");
                        break;
                    case "i am the most puny":
                        player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() + 1000);
                        Console.WriteLine("Pity money granted. Available money: £{0}", player.playerInventory.money.GetAmount());
                        Console.Write("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    case "demigod":
                        player.SetHealth(10000);
                        Console.WriteLine("Partial god status achieved. Health: {0}", player.GetHealth());
                        Console.Write("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    case "bandana":
                        player.playerInventory.ammo.SetAmount(99999);
                        player.playerInventory.antler.SetAvailable();
                        player.playerInventory.poisonSpear.SetAvailable();
                        player.playerInventory.toxicSludgePistol.SetAvailable();
                        player.playerInventory.guttingMachine.SetAvailable();
                        player.playerInventory.battleshipCannon.SetAvailable();
                        player.playerInventory.toxicSludgePistol.SetWeaponAmmo(99999);
                        player.playerInventory.battleshipCannon.SetWeaponAmmo(99999);
                        player.playerInventory.health.SetAmount(99999);
                        Console.WriteLine("A charitable shopkeeper donation occurred.");
                        Console.Write("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    case "show cheats":
                        Console.WriteLine("Bandana: Fill inventory");
                        Console.WriteLine("Demigod: 99999 Health");
                        Console.WriteLine("I am the most puny: Add £1000");
                        break;
                    case "fight 10":
                    case "fight10":
                    case "fight god":
                    case "fight god on acid":
                        if(enemies[0].CheckSeenOnce() || enemies[0].KilledOnce())
                        {
                            battleNum = 0;
                            enemies[0].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "fight 9":
                    case "fight9":
                    case "fight lonely panzer tank":
                    case "fight tank":
                        if (enemies[1].CheckSeenOnce() || enemies[1].KilledOnce())
                        {
                            battleNum = 1;
                            enemies[1].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "fight 8":
                    case "fight8":
                    case "fight bermuda triangle":
                    case "fight triangle":
                        if (enemies[2].CheckSeenOnce() || enemies[2].KilledOnce())
                        {
                            battleNum = 2;
                            enemies[2].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "fight 7":
                    case "fight7":
                    case "fight et":
                    case "fight e.t.":
                    case "fight e.t":
                    case "fight angry et":
                    case "fight angry e.t.":
                    case "fight angry e.t":
                        if (enemies[3].CheckSeenOnce() || enemies[3].KilledOnce())
                        {
                            battleNum = 3;
                            enemies[3].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "fight 6":
                    case "fight6":
                    case "fight doom turnip":
                    case "fight turnip":
                        if (enemies[4].CheckSeenOnce() || enemies[4].KilledOnce())
                        {
                            battleNum = 4;
                            enemies[4].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "fight 5":
                    case "fight5":
                    case "fight deadly nettle cluster":
                    case "fight nettle":
                    case "fight nettle cluster":
                        if (enemies[5].CheckSeenOnce() || enemies[5].KilledOnce())
                        {
                            battleNum = 5;
                            enemies[5].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "fight 4":
                    case "fight4":
                    case "fight failed gang member":
                    case "fight gang member":
                    case "fight gang":
                        if (enemies[6].CheckSeenOnce() || enemies[6].KilledOnce())
                        {
                            battleNum = 6;
                            enemies[6].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "fight 3":
                    case "fight3":
                    case "fight highly energetic spade":
                    case "fight energetic spade":
                    case "fight spade":
                        if (enemies[7].CheckSeenOnce() || enemies[7].KilledOnce())
                        {
                            battleNum = 7;
                            enemies[7].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "fight 2":
                    case "fight2":
                    case "fight burger with legs":
                    case "fight burger":
                        if (enemies[8].CheckSeenOnce() || enemies[8].KilledOnce())
                        {
                            battleNum = 8;
                            enemies[8].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "fight 1":
                    case "fight1":
                    case "fight fruitfly":
                    case "fight fruit fly":
                    case "fight fly":
                        if (enemies[9].CheckSeenOnce() || enemies[9].KilledOnce())
                        {
                            battleNum = 9;
                            enemies[9].Create();
                            fighting = true;
                            break;
                        }
                        else
                            break;
                    case "p":
                    case "progress":
                    case "check progress":
                        player.CheckProgress(player.playerInventory, enemies);
                        break;

                    case "help":
                        Console.WriteLine("\n_____ Available Commands _____");
                        Console.WriteLine("Some commands have shortcuts e.g. enter 'b' for battle\n");
                        Console.WriteLine("Battle: --------- Find battle!");
                        Console.WriteLine("Use health: ----- Use health pill.");
                        Console.WriteLine("Equip X: -------- Equip desired weapon.");
                        Console.WriteLine("                  (Can enter full weapon name or use numbers 1-6)");
                        Console.WriteLine("Fight X: -------- Fight desired enemy.");
                        Console.WriteLine("                  (Only possibly once discovered)");
                        Console.WriteLine("                  (Can enter full enemy name or use numbers 1-10)");
                        Console.WriteLine("Shop: ----------- Enter shop");
                        Console.WriteLine("Add ammo: ------- Add ammo to current weapon.");
                        Console.WriteLine("Player info: ---- View player info.");
                        Console.WriteLine("Weapon info: ---- View info for current weapon.");
                        Console.WriteLine("Inventory: ------ View inventory info.");
                        Console.WriteLine("Check progress: - Check game progress.");


                        Console.WriteLine("\nLoad: ----------- Load a game.");
                        Console.WriteLine("Save: ----------- Save game.");
                        Console.WriteLine("Game info: ------ Display game information.");
                        Console.WriteLine("Quit / Exit: ---- Exit game.\n");
                        break;
                    case "quit":
                    case "exit":
                        Console.Write("\nReally quit? Y/N : ");
                        switch (Console.ReadLine().ToLower())
                        {
                            case "y":
                            case "yes":
                                playing = false;
                                break;
                            case "n":
                            case "no":
                                break;
                        }
                        break;

                        

                }

                while(inShop)
                {
                    Console.WriteLine("\n_____ SHOP: Available Items _____");
                    Console.WriteLine("1. Health pill: £{0}", player.playerInventory.health.GetCost());
                    if (!player.playerInventory.antler.WeaponStatus())
                        Console.WriteLine("2. {0} : £{1}", player.playerInventory.antler.GetWeaponName(), player.playerInventory.antler.Getpower());
                    if (!player.playerInventory.poisonSpear.WeaponStatus())
                        Console.WriteLine("3. {0} : £{1}", player.playerInventory.poisonSpear.GetWeaponName(), player.playerInventory.poisonSpear.Getpower());
                    if (!player.playerInventory.toxicSludgePistol.WeaponStatus())
                        Console.WriteLine("4. {0} : £{1}", player.playerInventory.toxicSludgePistol.GetWeaponName(), player.playerInventory.toxicSludgePistol.Getpower());
                    if (!player.playerInventory.guttingMachine.WeaponStatus())
                        Console.WriteLine("5. {0} : £{1}", player.playerInventory.guttingMachine.GetWeaponName(), player.playerInventory.guttingMachine.Getpower());
                    if (!player.playerInventory.battleshipCannon.WeaponStatus())
                        Console.WriteLine("6. {0} : £{1}", player.playerInventory.battleshipCannon.GetWeaponName(), player.playerInventory.battleshipCannon.Getpower());
                    Console.WriteLine("7. 10 Ammo : £{0}", player.playerInventory.ammo.GetCost()*10);
                    Console.WriteLine("8. 20 Ammo : £{0}", player.playerInventory.ammo.GetCost() * 20);
                    Console.WriteLine("9. 50 Ammo : £{0}", player.playerInventory.ammo.GetCost() * 50);
                    Console.WriteLine("10. 100 Ammo : £{0}", player.playerInventory.ammo.GetCost() * 100);
                    
                    Console.WriteLine();
                    Console.WriteLine("Available funds: £{0}", player.playerInventory.money.GetAmount());
                    Console.WriteLine("Inventory ammo: {0}", player.playerInventory.ammo.GetAmount());
                    Console.WriteLine("Inventory health pills: {0}", player.playerInventory.health.GetAmount());
                    Console.WriteLine("Type 'buy #' to purchase item #.");
                    Console.WriteLine("Type 'leave' to leave shop.");;
                    Console.Write("Enter command: ");
                    command = Console.ReadLine().ToLower();
                    
                    Console.WriteLine("___________________________________");

                    switch (command)
                    {
                        case "i am the most puny":
                            player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() + 1000);
                            Console.WriteLine("Pity money granted. Available money: £{0}", player.playerInventory.money.GetAmount());
                            Console.Write("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case "demigod":
                            player.SetHealth(10000);
                            Console.WriteLine("Partial god status achieved. Health: {0}", player.GetHealth());
                            Console.Write("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case "bandana":
                            player.playerInventory.ammo.SetAmount(99999);
                            player.playerInventory.antler.SetAvailable();
                            player.playerInventory.poisonSpear.SetAvailable();
                            player.playerInventory.toxicSludgePistol.SetAvailable();
                            player.playerInventory.guttingMachine.SetAvailable();
                            player.playerInventory.battleshipCannon.SetAvailable();
                            player.playerInventory.toxicSludgePistol.SetWeaponAmmo(99999);
                            player.playerInventory.battleshipCannon.SetWeaponAmmo(99999);
                            player.playerInventory.health.SetAmount(99999);
                            Console.WriteLine("A charitable shopkeeper donation occurred.");
                            Console.Write("Press enter to continue...");
                            Console.ReadLine();
                            break;

                        case "buy 2":
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
                        case "buy 3":
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
                        case "buy 4":
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
                        case "buy 5":
                        case "buy gutting machine":
                        case "buy gut machine":
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
                        case "buy 6":
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
                        case "buy 1":
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
                        case "buy 7":
                        case "buy 10 ammo":
                            if (player.playerInventory.money.GetAmount() < player.playerInventory.ammo.GetCost()*10)
                            {
                                Console.WriteLine("\nYou don't have enough money, you microbe.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.ammo.SetAmount(player.playerInventory.ammo.GetAmount() + 10);
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.ammo.GetCost()*10);
                                Console.WriteLine("\n10 ammo bought.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "buy 8":
                        case "buy 20 ammo":
                            if (player.playerInventory.money.GetAmount() < player.playerInventory.ammo.GetCost() * 20)
                            {
                                Console.WriteLine("\nYou don't have enough money, you microbe.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.ammo.SetAmount(player.playerInventory.ammo.GetAmount() + 20);
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.ammo.GetCost() * 20);
                                Console.WriteLine("\n20 ammo bought.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "buy 9":
                        case "buy 50 ammo":
                            if (player.playerInventory.money.GetAmount() < player.playerInventory.ammo.GetCost() * 50)
                            {
                                Console.WriteLine("\nYou don't have enough money, you microbe.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.ammo.SetAmount(player.playerInventory.ammo.GetAmount() + 50);
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.ammo.GetCost() * 50);
                                Console.WriteLine("\n50 ammo bought.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "buy 10":
                        case "buy 100 ammo":
                            if (player.playerInventory.money.GetAmount() < player.playerInventory.ammo.GetCost() * 100)
                            {
                                Console.WriteLine("\nYou don't have enough money, you microbe.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                player.playerInventory.ammo.SetAmount(player.playerInventory.ammo.GetAmount() + 100);
                                player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() - player.playerInventory.ammo.GetCost() * 100);
                                Console.WriteLine("\n100 ammo bought.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        case "quit":
                        case "exit":
                            Console.Write("\nReally quit? Y/N : ");
                            switch (Console.ReadLine().ToLower())
                            {
                                case "y":
                                case "yes":
                                    inShop = false;
                                    playing = false;
                                    break;
                                case "n":
                                case "no":
                                    break;
                            }
                            break;
                        case "leave":
                        case "leave shop":
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
                            if (battleNum ==0)
                            {
                                Console.WriteLine("~~*~*~*~~*~*.~.* *.~.*~*~~*~*~*~~");
                                Console.WriteLine("*~* *~*~~*~._*.*~*.*_.~*~~*~* *~*");
                                Console.WriteLine("*~*~*~*~~*___*__~__*___*~~*~*~*~*");
                                Console.WriteLine("~~***~*~~*~___________~*~~*~***~~");
                                Console.WriteLine("~~*~*~   ________________  ~*~*~~");
                                Console.WriteLine("*~  ~ GOD!!!! ON!!! ACID!!! ~  ~*");
                                Console.WriteLine("~~*~*~   ________________  ~*~*~~");
                                Console.WriteLine("~~* *~*~~*~___________~*~~*~** ~~");
                                Console.WriteLine("*~*~*~*~~*___*__~__*___*~~*~*~*~*");
                                Console.WriteLine("*~*~ ~*~~*~._*.*~*.*_.~*~~*~* *~*");
                                Console.WriteLine("~~*~*~*~~*~*.~.* *.~.*~*~~*~*~*~~");
                            }
                            Console.WriteLine("_____ A wild {0} is attacking you! _____", enemies[battleNum].GetName());
                            Console.WriteLine("Your health: {0}", player.GetHealth());
                            Console.WriteLine("Equipped weapon: {0}", player.selectedWeapon.GetWeaponName());
                            Console.WriteLine("Weapon ammo: {0}", player.selectedWeapon.GetWeaponAmmo());
                            Console.WriteLine("Enemy health: {0}", enemies[i].GetHealth());
                            Console.WriteLine("Enemy power: {0}", enemies[i].GetAttackDamage());
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
                        case "i am the most puny":
                            player.playerInventory.money.SetAmount(player.playerInventory.money.GetAmount() + 1000);
                            Console.WriteLine("Pity money granted. Available money: £{0}", player.playerInventory.money.GetAmount());
                            Console.Write("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case "demigod":
                            player.SetHealth(10000);
                            Console.WriteLine("Partial god status achieved. Health: {0}", player.GetHealth());
                            Console.Write("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case "bandana":
                            player.playerInventory.ammo.SetAmount(99999);
                            player.playerInventory.antler.SetAvailable();
                            player.playerInventory.poisonSpear.SetAvailable();
                            player.playerInventory.toxicSludgePistol.SetAvailable();
                            player.playerInventory.guttingMachine.SetAvailable();
                            player.playerInventory.battleshipCannon.SetAvailable();
                            player.playerInventory.toxicSludgePistol.SetWeaponAmmo(99999);
                            player.playerInventory.battleshipCannon.SetWeaponAmmo(99999);
                            player.playerInventory.health.SetAmount(99999);
                            Console.WriteLine("A charitable shopkeeper donation occurred.");
                            Console.Write("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case "a":
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
                                    Console.WriteLine("Current weapon: {0}", player.selectedWeapon.GetWeaponName());
                                    Console.WriteLine("Weapon ammo: {0}", player.selectedWeapon.GetWeaponAmmo());
                                    Console.WriteLine("Invetory ammo: {0}", player.playerInventory.ammo.GetAmount());
                                    Console.WriteLine("Current points: {0}", player.GetPoints());
                                    Console.WriteLine("Current money: £{0}", player.playerInventory.money.GetAmount());
                                    Console.Write("Press enter to continue");
                                    Console.ReadLine();
                                    enemies[battleNum].CheckFirstKill();
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
                                Console.WriteLine("You have no ammo!\nAdd ammo or equip another weapon.");
                                Console.Write("Press enter to continue...");
                                Console.ReadLine();
                                break;
                            }

                        case "ammo":
                        case "add ammo":
                            if (player.playerInventory.ammo.GetAmount() == 0)
                            {
                                Console.WriteLine("\nNo ammo left!\n");
                                break;
                            }
                            else
                                player.Use("ammo");
                            break;
                        case "h":
                        case "health":
                        case "use health":
                            if (player.playerInventory.health.GetAmount() == 0)
                            {
                                Console.WriteLine("\nNo health pills left!\n");
                                break;
                            }
                            else
                                player.Use("health");
                            break;
                        case "1":
                        case "equip 1":
                        case "equip fork":
                            player.Equip("fork");
                            break;
                        case "2":
                        case "equip 2":
                        case "equip antler":
                            player.Equip("antler");
                            break;
                        case "3":
                        case "equip 3":
                        case "equip poison spear":
                            player.Equip("poison spear");
                            break;
                        case "equip spear":
                            player.Equip("spear");
                            break;
                        case "4":
                        case "equip 4":
                        case "equip sludge pistol":
                            player.Equip("sludge pistol");
                            break;
                        case "equip toxic sludge pistol":
                            player.Equip("toxic sludge pistol");
                            break;
                        case "equip pistol":
                            player.Equip("pistol");
                            break;
                        case "5":
                        case "equip 5":
                        case "equip gutting machine":
                            player.Equip("gutting machine");
                            break;
                        case "equip gut machine":
                            player.Equip("gut machine");
                            break;
                        case "6":
                        case "equip 6":
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
                        case "f":
                        case "flee":
                            Console.WriteLine("A pathetic escape!");
                            Console.WriteLine("You lose 10 points, feeble worm!\n");
                            player.SetPoints(player.GetPoints() - 10);
                            Console.WriteLine("Current health: {0}", player.GetHealth());
                            Console.WriteLine("Current weapon: {0}", player.selectedWeapon.GetWeaponName());
                            Console.WriteLine("Weapon ammo: {0}", player.selectedWeapon.GetWeaponAmmo());
                            Console.WriteLine("Invetory ammo: {0}", player.playerInventory.ammo.GetAmount());
                            Console.WriteLine("Current points: {0}", player.GetPoints());
                            Console.WriteLine("Current money: £{0}", player.playerInventory.money.GetAmount());
                            enemies[battleNum].SeenOnce();
                            enemies[battleNum].Kill();
                            fighting = false;
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            break;

                        case "wi":
                        case "weapon":
                        case "weapon info":
                            player.selectedWeapon.WeaponInfo();
                            break;
                        case "pi":
                        case "player":
                        case "player info":
                            player.ViewPlayerStats();
                            break;
                        case "ei":
                        case "enemy":
                        case "enemy info":
                            for (int i = 0; i < 10; i++)
                            {
                                if (enemies[i].Exists())
                                {
                                    enemies[i].EnemyInfo();
                                }
                            }
                            break;
                        case "i":
                        case "inventory info":
                        case "view inventory":
                        case "inventory":
                            player.playerInventory.InventoryInfo();
                            break;

                        case "help":
                            Console.WriteLine("\n_____ Available Commands _____");
                            Console.WriteLine("Some commands have shortcuts e.g. enter 'a' for attack\n");
                            Console.WriteLine("Attack: --------- Atack enemy using current weapon.");
                            Console.WriteLine("Use health: ----- Use health pill.");
                            Console.WriteLine("Equip X: -------- Equip desired weapon.");
                            Console.WriteLine("                  (Can enter full weapon name or use numbers 1-6)");
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
