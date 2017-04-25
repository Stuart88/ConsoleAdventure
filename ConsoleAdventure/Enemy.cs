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
        public int startHealth;
        protected int health;
        protected int attackDamage;
        protected int resetHealth;
        protected bool exists;
        protected bool killedOnce;
        protected bool seenOnce;
        

        public Enemy(string name, int health, int startHealth, int attackDamage)
        {
            this.name = name;
            this.health = health;
            resetHealth = health;
            this.startHealth = startHealth;
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

        public void GetEnemyImage(int i)
        {
            if (i == 0)
            {
                Console.WriteLine(@"
                            ,-.                               
              ___, ---.__ / '|`\          __,---,___          
    , -'    \`    `-.____,-' |  `-.____, -'    //    `-.       
  , '        |           ~'\     /`~           |        `.      
 /       ___//              `. ,'          ,  , \___      \    
|    , -'   `-.__   _         |        ,    __,-'   `-.    |
|   /          /\_  `   .    |    , _     /\          \   |
\  |           \ \`-.___ \   |   / ___,-'/ /           |  /  
 \  \           | `._   `\\  |  //'    _,' |           /  /      
  `-.\         / '  _ `---'' , . ``---' _  `\         /,-'     
     ``       /     \    ,= '/ \`=.    /     \       ''          
             | __ /|\_,--., -.--, --._  /|\ __ |
             /  `./  \\`\ |   |  | /,//'   \,'  \                  
            /   /     ||--+-- | --+-/-|     \   \                 
           |   |     / '\_\_\ | /_/_/`\     |   |                
            \   \__, \_     `~'     _/  .__/   /            
             `-._, -'   `-._______,-'   `-._,-' ");
            }

            if(i==1)
            {
                Console.WriteLine(@"
                            _________________
  [ O ]                   /                   \
     \ \                 (  Ich bin Führious!  )
      \ \    o/        /  \ _________________ /
       \ \--'---_     /
       /\ \   / ~~\_
 ./---/__|=/_/------//~~~\
/___________________/O   O \
(===(\_________(===(Oo o o O)          
 \~~~\____/     \---\Oo__o--
   ~~~~~~~       ~~~~~~~~~~
");
            }

            if(i==2)
            {
                Console.WriteLine(@"
             .  eer
              .d$'
             - '$$$$$P
             .'$$$$P
             .J *$$F.
          . . ^ $$$$$r
        - *$$$r ^ **C$$b
      $ed$$$$'    *$$$b.
      *$$$$$F      $$$$$
      J *$$$$F   zee$$$$$P
    - J$$$$$$    ^$$$$$$$$$$b
    ^ '*''     4*$$$$$$$$$$*'
                .J.d$$$$$e.
               d$P'**'''''
                ");
            }

            if (i == 3)
            {
                Console.WriteLine(@"
                                     .:::--...`                            
                               `:+yhmNNo``..`.-/s:                         
                           ./oyyysoo+:``      `/shd+.                      
                        :++yhyo/------.`    `/+syyhhhys/`                  
                     -:/-` .:..-//. .--- `  -/sso++oosymd-                 
                    +-                 .`.//-````    ``./o+.               
                   +.  .-::.. .          .   .       ` `  `+/              
                  o`.-:hs///:/so-`   `.   `- +`:`+::syyo+o-`s`             
                 /+ `//+syhhs:::yso+::.` `.+sys+s+.-/+oo/-o-/:             
                 s:.o.:domddNNso.o`:so+- `-/+-o:yoymdmNysh`s/+             
                 ++ / `yomdddd-+ s`so:-.`:+ys.+/N+hmhmmm/s:/o/             
                 `h``-/./shdhso::-.s:o/``+s//+`+/yohhhhhs/s o-             
                  /s ``oss/++o+o/::++-` `-so:./.:.---.++o-..y              
                   :o/--:-.-/://.`     .      `/-``--:/-.-/+`              
                    `.-s+-  /+o-       /       `//.-ooyo/-`                
                       `oo.`o/y-       +       `os++ho-`                   
                         -/oo:--//-.   -  `.-:/+//:+/                      
                            .-/o+:::/++++o+///+/+++-                       
                               .m/-://+oooo+/oy.`                          
                                yo-`  ```  `-o`                            
                                h/``       `/+                             
 ");
            }

            if (i == 4)
            {
                Console.WriteLine(@"
                       ___
               `-._\ /     `~~'--., _
              ------ >|              `~~'--.,_
               _.- '/ '.____,,,, ----'''~~```'");
            }

            if (i == 5)
            {
                Console.WriteLine(@"
                                            _._
                                          .'   '.
                                         /       \  ___
                        _..       _.--. |     /  |.'   `'.
               ;-._   .'   `\   .'     `\   \|   /        \
             .'    `\/       ; /     _   \.=..=./  _.'    /
             |       `\.---._| '.   .-'-.}`.<>.`{-'-.    /
          .--;   . ( .'      '.  \ .---.{ <>()<> }.--..-'
         / _  \_  './ _.       `-./     _},'<>`.{_    `\
        ( = \  )`""'\;--.         /  .-'/ )=..=;`\`-    \
        {= (|  )     /`.         /       /  /| \         )
        ( =_/  )__..-\         .'-..___.'    :  '.___..-'
         \    }/    / ;.____.-;/\      |      `   |
          '--' |  .'   |       \ \     /'.      _.'
               \  '    /       |\.\   ;  /`--.-'
                )    .'`-.    /  \ \  |`|
               /__.-'     \_.'    \ \ |-|");
            }

            if (i == 6)
            {
                Console.WriteLine(@"
            ||||||||||||||
           =              \       ,
           =               |
          _=            ___/
         / _\           (o)\
        | | \            _  \
        | |/            (____)
         \__/          /   |
          /           /  ___)
         /    \       \    _)                       )
        \      \           /                       (
      \/ \      \_________/   |\_________________,_ )
       \/ \      /            |     ==== _______)__)
        \/ \    /           __/___  ====_/
         \/ \  /           (O____)\\_(_/
                          (O_ ____)
                           (O____)");
            }

            if (i == 7)
            {
                Console.WriteLine(@"
             ***
            * //*
             //*
   **       **/|      **
 ************//***********
 ***********//************
   **      |/**       **
            **/|
            *//
            //*
           |/**
            **/|
***         *//         ***
 *****      //*      *****
  *******  |/**   *******
       *************
          *******
             *");
            }

            if (i == 8)
            {
                Console.WriteLine(@"
           _....----''''----...._
        .- '  o    o    o    o   ' -.
       / o    o    o         o    \  
    __ / __o___o_ _ o___ _ o_ o_ _ _o_\__
   /                                   \
   \___________________________________ /
     \~`-`.__.`-~`._.~`-`~.- ~.__.~`-`/
      \                             /
       `-._______________________.- 
                /\       /\
                | `-._.-` |
                \   / \   /
                |_ |   | _|
                | _|   |_ |
                (ooO   Ooo)
");

            }

            if (i == 9)
            {
                Console.WriteLine(@"
      ____
     ;----""(#)
      '--|-|'|'
        /  |  \ ");
            }
        }

        public void GodKilled()
        {
            Console.WriteLine("____________________________");
            Console.WriteLine("YOU HAVE KILLED GOD ON ACID!");
            Console.WriteLine("____________________________\n");
            Console.WriteLine("Congratulations, weak scum, you have\n" +
                "survived the most epic adventure on earth.\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        public void Reset()
        {
            SetHealth(startHealth);
            exists = false;
            killedOnce = false;
            seenOnce = false;

        }
        
    }
}
