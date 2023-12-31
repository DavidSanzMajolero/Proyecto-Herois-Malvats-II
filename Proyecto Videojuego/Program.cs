using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameProject 
{

    public static class GraphicFunc
    {
        public static void DrawWelcome()
        {
            const string Intro = "Pressiona INTRO per saltar la pantalla en negre", OpenTerminal = "Obre la terminal per a una millor experiencia...", Choose = "Què vols fer?", Play = "Jugar (0)", Leave = "Sortir (1)";
            const string Screen = $@"
                             ···························································································
                             :                                                                                         :
                             : ██████╗ ███████╗███╗   ██╗██╗   ██╗██╗███╗   ██╗ ██████╗ ██╗   ██╗████████╗     █████╗  :
                             : ██╔══██╗██╔════╝████╗  ██║██║   ██║██║████╗  ██║██╔════╝ ██║   ██║╚══██╔══╝    ██╔══██╗ :
                             : ██████╔╝█████╗  ██╔██╗ ██║██║   ██║██║██╔██╗ ██║██║  ███╗██║   ██║   ██║       ███████║ :
                             : ██╔══██╗██╔══╝  ██║╚██╗██║╚██╗ ██╔╝██║██║╚██╗██║██║   ██║██║   ██║   ██║       ██╔══██║ :
                             : ██████╔╝███████╗██║ ╚████║ ╚████╔╝ ██║██║ ╚████║╚██████╔╝╚██████╔╝   ██║       ██║  ██║ :
                             : ╚═════╝ ╚══════╝╚═╝  ╚═══╝  ╚═══╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝  ╚═════╝    ╚═╝       ╚═╝  ╚═╝ :
                             :                                                                                         :
                             : ██╗  ██╗███████╗██████╗  ██████╗ ██╗███████╗    ██╗   ██╗███████╗                       :
                             : ██║  ██║██╔════╝██╔══██╗██╔═══██╗██║██╔════╝    ██║   ██║██╔════╝                       :
                             : ███████║█████╗  ██████╔╝██║   ██║██║███████╗    ██║   ██║███████╗                       :
                             : ██╔══██║██╔══╝  ██╔══██╗██║   ██║██║╚════██║    ╚██╗ ██╔╝╚════██║                       :
                             : ██║  ██║███████╗██║  ██║╚██████╔╝██║███████║     ╚████╔╝ ███████║                       :
                             : ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝╚══════╝      ╚═══╝  ╚══════╝                       :
                             :                                                                                         :
                             : ███╗   ███╗ ██████╗ ███╗   ██╗███████╗████████╗██████╗ ███████╗███████╗                 :
                             : ████╗ ████║██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔══██╗██╔════╝██╔════╝                 :
                             : ██╔████╔██║██║   ██║██╔██╗ ██║███████╗   ██║   ██████╔╝█████╗  ███████╗                 :
                             : ██║╚██╔╝██║██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══██╗██╔══╝  ╚════██║                 :
                             : ██║ ╚═╝ ██║╚██████╔╝██║ ╚████║███████║   ██║   ██║  ██║███████╗███████║                 :
                             : ╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝  ╚═╝╚══════╝╚══════╝                 :
                             :                                                                                         :
                             ···························································································
            ";
            const string Pc = @"
                                                                    _________________
                                                                   |                 |
                                                                   |   ___________   |
                                                                   |  |  Jugar 0  |  |
                         ______________________________________    |  |___________|  |
                        |  __________________________________  |   |   ___________   |
                        | |                                  | |   |  |  Sortir 1 |  |
                        | |       MONSTRES VS HEROIS         | |   |  |___________|  |
                        | |              _  _                | |   |   __   __   _   |
                        | |            (_>()<_)              | |   |  |__| |__| |_|  |
                        | |             (_/\_)               | |   |                 |
                        | |               ||                 | |   |                 |
                        | |             | || |               | |   |                 |
                        | |            __\||/__              | |   |                 |
                        | |                                  | |   |       .|.       |
                        | |                                  | |   |      (   )      |
                        | |                  By David Sanz   | |   |       '-'       |
                        | |__________________________________| |   |                 |
                        |______________________________________|   |                 |
                                         |    |      '.            |                 |
                                         |    |        '-.-'-.-'-.-|                 |
                                         )    (                    |                 |
                                        /      \                   |                 |
                                       /________\                  |_________________|
            ";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Screen);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Intro);
            Console.ResetColor();
            Console.ReadLine();
            Console.WriteLine(OpenTerminal);
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(Choose);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Play);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Leave);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(Pc);
            Console.ResetColor();
        }
        public static void Archer()
        {
            const string Archer = @"          
                           4$$-.                                          
                           4   "".                                       
                           4    ^.                                       
                           4     $                                       
                           4     'b                                      
                           4      ""b.                                   
                           4        $                                    
                           4        $r                                   
                           4        $F                                   
                -$b========0========$b====*P=->>                         
                           4       *$$F                                 
                           4        $$""                                
                           4       .$F                                  
                           4       dP                                   
                           4      F                                     
                           4     @                                      
                           4    .                                       
                           J.  .                                         
                          '$$
            ";
            Console.WriteLine(Archer);
        }
        public static void Barbarian()
        {
            const string Barbarian = @"
                                       /\  |\
                                     __)(__) \
                                    (__{}__   >
                                       ||  ) /
                                       ||  |/
                                       ||
                                       ||
                                       ||
                                       ||
                                       ||
                                       /\
                                      '--'";
            Console.WriteLine(Barbarian);
        }
        public static void Mage()
        {
            const string Mage = @"
                                        _.-.
                                    .-'%%~%'.
                                 _.'%%¨_.'-._\
                               .'%%%%~|      '
                              '%¨%%%%%-
                    .________/_________\_______.
                     ¨¨°¨°¨¨            ¨°¨¨¨°¨";
            Console.WriteLine(Mage);
        }
        public static void Druid()
        {
            const string Druid =@"  
                                    .   .   .
                                   / \\/ \\/ \
                                   \\_     _//
                                     \\_ _//
                                       | |
                                       | |
                                       | |
                                       | |
                                       | |
                                       | |
                                       | |
                                       | |
                                       | |
                                       | |
                                       | |
                                       | |
                                       | |
                                       |_| 
                                       ( )
                                      _/ \_
                                     /_____\ ";
            Console.WriteLine(Druid);
        }
        public static void Monster()
        {
            const string Monster = @"
                                                                  ,--,  ,.-.
                                   ,                   \,       '-,-`,'-.' | ._
                                  /|           \    ,   |\         }  )/  / `-,'
                                  [ ,          |\  /|   | |        /  \|  |/`  ,`
                                  | |       ,.`  `,` `, | |  _,...(   (      .',
                                  \  \  __ ,-` `  ,  , `/ |,'      Y     (   /_L\
                                   \  \_\,``,   ` , ,  /  |         )         _,/
                                    \  '  `  ,_ _`_,-,<._.<        /         /
                                     ', `>.,`  `  `   ,., |_      |         /
                                       \/`  `,   `   ,`  | /__,.-`    _,   `\
                                   -,-..\  _  \  `  /  ,  / `._) _,-\`       \
                                    \_,,.) /\    ` /  / ) (-,, ``    ,        |
                                   ,` )  | \_\       '-`  |  `(               \
                                  /  /```(   , --, ,' \   |`<`    ,            |
                                 /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)
                           ,-, ,`   `   (_,\ \    |   /) / __/  /   `----`
                          (-, \           ) \ ('_.-._)/ /,`    /
                          | /  `          `/ \\ V   V, /`     /
                       ,--\(        ,     <_/`\\     ||      /
                      (   ,``-     \/|         \-A.A-`|     /
                     ,>,_ )_,..(    )\          -,,_-`  _--`
                    (_ \|`   _,/_  /  \_            ,--`
                     \( `   <.,../`     `-.._   _,-` ";
            Console.WriteLine(Monster);
        }
        public static void StartBattle()
        {
            const string StartBattle = @"
                  ______   ______   .___  ___.  _______ .__   __.   ______  _______ .___  ___.     __          ___         .______        ___   .___________.    ___       __       __          ___       __ 
                 /      | /  __  \  |   \/   | |   ____||  \ |  |  /      ||   ____||   \/   |    |  |        /   \        |   _  \      /   \  |           |   /   \     |  |     |  |        /   \     |  |
                |  ,----'|  |  |  | |  \  /  | |  |__   |   \|  | |  ,----'|  |__   |  \  /  |    |  |       /  ^  \       |  |_)  |    /  ^  \ `---|  |----`  /  ^  \    |  |     |  |       /  ^  \    |  |
                |  |     |  |  |  | |  |\/|  | |   __|  |  . `  | |  |     |   __|  |  |\/|  |    |  |      /  /_\  \      |   _  <    /  /_\  \    |  |      /  /_\  \   |  |     |  |      /  /_\  \   |  |
                |  `----.|  `--'  | |  |  |  | |  |____ |  |\   | |  `----.|  |____ |  |  |  |    |  `----./  _____  \     |  |_)  |  /  _____  \   |  |     /  _____  \  |  `----.|  `----./  _____  \  |__|
                 \______| \______/  |__|  |__| |_______||__| \__|  \______||_______||__|  |__|    |_______/__/     \__\    |______/  /__/     \__\  |__|    /__/     \__\ |_______||_______/__/     \__\ (__)
                ";
            Console.WriteLine(StartBattle);
        }
        public static void Skull()
        {
            long skullCount = 5, timerSkull = 50000000; 
            while (skullCount > 0)
            {
                Console.WriteLine(@"
                                                            ,--.
                                                           {    }
                                                           K,   }
                                                          /  ~Y`
                                                     ,   /   /
                                                    {_'-K.__/
                                                      `/-.__L._
                                                      /  ' /`\_}
                                                     /  ' /
                                             ____   /  ' /
                                      ,-'~~~~    ~~/  ' /_
                                    ,'             ``~~~  ',
                                   (                        Y
                                  {                         I
                                 {      -                    `,
                                 |       ',                   )
                                 |        |   ,..__      __. Y
                                 |    .,_./  Y ' / ^Y   J   )|
                                 \           |' /   |   |   ||
                                  \          L_/    . _ (_,.'(
                                   \,   ,      ^^""' / |      )
                                     \_  \          /,L]     /
                                       '-_~-,       ` `   ./`
                                          `'{_            )
                                              ^^\..___,.--`

                            ");
                while (timerSkull > 0)
                {
                    timerSkull--;
                }
                Console.Clear();
                timerSkull = 50000000;
                Console.WriteLine(@"
                                                                        ,--.
                                                                       {    }
                                                                       K,   }
                                                                      /  ~Y`
                                                                 ,   /   /
                                                                {_'-K.__/
                                                                  `/-.__L._
                                                                  /  ' /`\_}
                                                                 /  ' /
                                                         ____   /  ' /
                                                  ,-'~~~~    ~~/  ' /_
                                                ,'             ``~~~  ',
                                               (                        Y
                                              {                         I
                                             {      -                    `,
                                             |       ',                   )
                                             |        |   ,..__      __. Y
                                             |    .,_./  Y ' / ^Y   J   )|
                                             \           |' /   |   |   ||
                                              \          L_/    . _ (_,.'(
                                               \,   ,      ^^""' / |      )
                                                 \_  \          /,L]     /
                                                   '-_~-,       ` `   ./`
                                                      `'{_            )
                                                          ^^\..___,.--`

                            ");
                while (timerSkull > 0)
                {
                    timerSkull--;
                }
                timerSkull = 50000000;
                Console.Clear();
                skullCount--;
            }
            skullCount = 5;
        }
        public static void Lose()
        {
            const string Lose = @"


                             .+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+. 
                            (                                                                                                             )
                             )                                                                                                           ( 
                            (                                                                                                             )
                             )      ██░ ██  ▄▄▄        ██████     ██▓███  ▓█████  ██▀███  ▓█████▄  █    ██ ▄▄▄█████▓                     ( 
                            (      ▓██░ ██▒▒████▄    ▒██    ▒    ▓██░  ██▒▓█   ▀ ▓██ ▒ ██▒▒██▀ ██▌ ██  ▓██▒▓  ██▒ ▓▒                      )
                             )     ▒██▀▀██░▒██  ▀█▄  ░ ▓██▄      ▓██░ ██▓▒▒███   ▓██ ░▄█ ▒░██   █▌▓██  ▒██░▒ ▓██░ ▒░                     ( 
                            (      ░▓█ ░██ ░██▄▄▄▄██   ▒   ██▒   ▒██▄█▓▒ ▒▒▓█  ▄ ▒██▀▀█▄  ░▓█▄   ▌▓▓█  ░██░░ ▓██▓ ░                       )
                             )     ░▓█▒░██▓ ▓█   ▓██▒▒██████▒▒   ▒██▒ ░  ░░▒████▒░██▓ ▒██▒░▒████▓ ▒▒█████▓   ▒██▒ ░  ██▓  ██▓  ██▓       ( 
                            (       ▒ ░░▒░▒ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░   ▒▓▒░ ░  ░░░ ▒░ ░░ ▒▓ ░▒▓░ ▒▒▓  ▒ ░▒▓▒ ▒ ▒   ▒ ░░    ▒▓▒  ▒▓▒  ▒▓▒        )
                             )      ▒ ░▒░ ░  ▒   ▒▒ ░░ ░▒  ░ ░   ░▒ ░      ░ ░  ░  ░▒ ░ ▒░ ░ ▒  ▒ ░░▒░ ░ ░     ░     ░▒   ░▒   ░▒        ( 
                            (       ░  ░░ ░  ░   ▒   ░  ░  ░     ░░          ░     ░░   ░  ░ ░  ░  ░░░ ░ ░   ░       ░    ░    ░          )
                             )      ░  ░  ░      ░  ░      ░                 ░  ░   ░        ░       ░                ░    ░    ░        ( 
                            (                                                              ░                          ░    ░    ░         )
                             )                                                                                                           ( 
                            (                                                                                                             )
                             )                                                                                                           ( 
                            (                                                                                                             )
                             ""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+"" 

                    ";
            Console.WriteLine(Lose);
        }
        public static void Win()
        {
            const string Congrats =@"

                        ┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐
                        │                                                                                                                                                                          │
                        │  ███████╗███████╗██╗     ██╗ ██████╗██╗████████╗ █████╗ ████████╗███████╗    ██╗  ██╗ █████╗ ███████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗██╗   ██╗ █████╗ ████████╗  │
                        │  ██╔════╝██╔════╝██║     ██║██╔════╝██║╚══██╔══╝██╔══██╗╚══██╔══╝██╔════╝    ██║  ██║██╔══██╗██╔════╝    ██╔════╝ ██║   ██║██╔══██╗████╗  ██║╚██╗ ██╔╝██╔══██╗╚══██╔══╝  │
                        │  █████╗  █████╗  ██║     ██║██║     ██║   ██║   ███████║   ██║   ███████╗    ███████║███████║███████╗    ██║  ███╗██║   ██║███████║██╔██╗ ██║ ╚████╔╝ ███████║   ██║     │
                        │  ██╔══╝  ██╔══╝  ██║     ██║██║     ██║   ██║   ██╔══██║   ██║   ╚════██║    ██╔══██║██╔══██║╚════██║    ██║   ██║██║   ██║██╔══██║██║╚██╗██║  ╚██╔╝  ██╔══██║   ██║     │
                        │  ██║     ███████╗███████╗██║╚██████╗██║   ██║   ██║  ██║   ██║   ███████║    ██║  ██║██║  ██║███████║    ╚██████╔╝╚██████╔╝██║  ██║██║ ╚████║   ██║   ██║  ██║   ██║     │
                        │  ╚═╝     ╚══════╝╚══════╝╚═╝ ╚═════╝╚═╝   ╚═╝   ╚═╝  ╚═╝   ╚═╝   ╚══════╝    ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝     ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝   ╚═╝     │
                        │                                                                                                                                                                          │
                        └──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘
                    ";
            const string Medal =@"    
                                                                                                             _______________
                                                                                                            |@@@@|     |####|
                                                                                                            |@@@@|     |####|
                                                                                                            |@@@@|     |####|
                                                                                                            \@@@@| ITB |####/
                                                                                                             \@@@|     |###/
                                                                                                              `@@|_____|##'
                                                                                                                   (O)
                                                                                                                .-'''''-.
                                                                                                              .'  * * *  `.
                                                                                                             :  *       *  :
                                                                                                            : ~ G U A N Y ~ :
                                                                                                            : ~ A D O R ! ~ :
                                                                                                             :  *       *  :
                                                                                                              `.  * * *  .'
                                                                                                                `-.....-'
                    ";
            Console.WriteLine(Congrats);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Medal);   
        }
    }
    public static class Func
    {
        public static float[] EasyHardMode(float m1, float m2,  float m3,  float m4)
        {
            float[] array = new float[4];
            array[0] = m1;
            array[1] = m2;
            array[2] = m3;
            array[3] = m4;
            return array;
        }
        public static float[] EasyHardMode(float m1, float m2, float m3, bool monster)
        {

            float[] array = new float[3];
            array[0] = m1;
            array[1] = m2;
            array[2] = m3;
            return array;
        }

        public static float[] RandomMode(float min1, float max1, float min2, float max2, float min3, float max3, float min4, float max4)
        {
            Random random = new Random();
            float[] array = new float[4];
            array[0] = (float)random.Next((int)min1, (int)max1 + 1);
            array[1] = (float)random.Next((int)min2, (int)max2 + 1);
            array[2] = (float)random.Next((int)min3, (int)max3 + 1);
            array[3] = (float)random.Next((int)min4, (int)max4 + 1);
            return array;
        }
        public static float[] RandomMode(float min1, float max1, float min2, float max2, float min3, float max3, bool monster)
        {
            Random random = new Random();
            float[] array = new float[3];
            array[0] = (float)random.Next((int)min1, (int)max1 + 1);
            array[1] = (float)random.Next((int)min2, (int)max2 + 1);
            array[2] = (float)random.Next((int)min3, (int)max3 + 1);
            return array;
        }


    }


    class SanzDavidCode
    {
        public static void Main()
        {
            const int minVidaArquera = 1500, maxVidaArquera = 2000, minAtacArquera = 200, maxAtacArquera = 300, minDefensaArquera = 25, maxDefensaArquera = 35;
            const int minVidaBarbaro = 3000, maxVidaBarbaro = 3750, minAtacBarbaro = 150, maxAtacBarbaro = 250, minDefensaBarbaro = 35, maxDefensaBarbaro = 45;
            const int minVidaMaga = 1100, maxVidaMaga = 1500, minAtacMaga = 300, maxAtacMaga = 400, minDefensaMaga = 20, maxDefensaMaga = 35;
            const int minVidaDruida = 2000, maxVidaDruida = 2500, minAtacDruida = 70, maxAtacDruida = 120, minDefensaDruida = 25, maxDefensaDruida = 40;
            const int minVidaMonstre = 7000, maxVidaMonstre = 10000, minAtacMonstre = 300, maxAtacMonstre = 400, minDefensaMonstre = 20, maxDefensaMonstre = 30;

            float[] arrayHP = new float[4], arrayAttack = new float[4], arrayDeff = new float[4], arrayMonster = new float[3];
            float numStart, countInicial = 0, dificultselector;
            
            bool monster = true;
            float hpArquera = 0, defArquera = 0, hpBarbaro = 0, defBarbaro = 0, hpMaga = 0, defMaga = 0, hpDruida = 0, defDruida = 0, hpMonstre = 0, defMonstre = 0, atacArquera = 0, atacBarbaro = 0, atacMaga = 0, atacDruida = 0, atacMonstre = 0;
            const string monstre = "Monstre ", arquera = "Arquera ", barbaro = "Bàrbar ", maga = "Maga ", druida = "Druida "; //noms strings
            string Names;
            string[] arrayNombres;

            

            //SHOW WELCOME
            GraphicFunc.DrawWelcome(); 
            
            //CHOOSE PLAY OR LEAVE
            numStart = Convert.ToInt32(Console.ReadLine());
            while (numStart != 0 && numStart != 1)
            {
                countInicial++;
                if (countInicial >= 3) return;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("El numero a de ser [0] o [1]");
                numStart = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
            }
            countInicial = 0;
            while (numStart == 0)
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("Perfecte. Comencem a crear personatges!");
                Console.ReadKey();
                Console.WriteLine("Escriu el nom dels 4 personatges");
                Names = Console.ReadLine();
                arrayNombres = Names.Split(','); //store the names in an array
                Console.WriteLine("Quin nivell de dificultat vols?");
                Console.WriteLine("1.Fàcil\t2.Dificil\t3.Personalitzat\t4.Random");
                do
                {
                    dificultselector = Convert.ToInt32(Console.ReadLine());
                } while (dificultselector != 1 && dificultselector != 2 && dificultselector != 3 && dificultselector != 4);
                switch (dificultselector)
                {
                    case 1:
                        arrayHP = Func.EasyHardMode(maxVidaArquera, maxVidaBarbaro, maxVidaMaga, maxVidaDruida);
                        arrayAttack = Func.EasyHardMode(maxAtacArquera, maxAtacBarbaro, maxAtacMaga, maxAtacDruida);
                        arrayDeff = Func.EasyHardMode(maxDefensaArquera, maxDefensaBarbaro, maxDefensaMaga, maxDefensaDruida);
                        arrayMonster = Func.EasyHardMode(minVidaMonstre, minAtacMonstre, minDefensaMonstre, monster);

                    break;

                    case 2:
                        arrayHP = Func.EasyHardMode(minVidaArquera, minVidaBarbaro, minVidaMaga, minVidaDruida);
                        arrayAttack = Func.EasyHardMode(minAtacArquera, minAtacBarbaro, minAtacMaga, minAtacDruida);
                        arrayDeff = Func.EasyHardMode(minDefensaArquera, minDefensaBarbaro, minDefensaMaga, minDefensaDruida);
                        arrayMonster = Func.EasyHardMode(maxVidaMonstre, maxAtacMonstre, maxDefensaMonstre, monster);
                        break;

                    case 3:
                        //Func.CostumizeMode();
                    break;

                    case 4:
                        arrayHP = Func.RandomMode(minVidaArquera, maxVidaArquera, minVidaBarbaro, maxVidaBarbaro, minVidaMaga, maxVidaMaga, minVidaDruida, maxVidaDruida);
                        arrayAttack = Func.RandomMode(minAtacArquera, maxAtacArquera, minAtacBarbaro, maxAtacBarbaro, minAtacMaga, maxAtacMaga, minAtacDruida, maxAtacDruida);
                        arrayDeff = Func.RandomMode(minDefensaArquera,maxDefensaArquera, minDefensaBarbaro, maxDefensaBarbaro, minDefensaMaga, maxDefensaMaga, minDefensaDruida, maxDefensaDruida);
                        arrayMonster = Func.RandomMode(minVidaMonstre, maxVidaMonstre, minAtacMonstre, maxAtacMonstre, minDefensaMonstre, maxDefensaMonstre, monster);
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;

                //START BATTLE
                GraphicFunc.StartBattle();

                Console.ResetColor();
                //variables i constantes batalla
                const string mortArquera = "La arquera a perdut tota la vida i ha mort", mortBarbaro = "El  barbar  a perdut tota la vida i ha mort", mortMaga = "La maga a perdut tota la vida i ha mort", mortDruida = "El  druida  a perdut tota la vida i ha mort"; //mort herois
                const string errorValors = "Els valors que has escrit estan malament, torna a escriure-ls", errorsEsgotats = "Errors esgotats, reiniciant programa";
                const string selAccio = "Selecciona l'acció", atacar = "1.Atacar", protegirse = "2.Protegirse", habEspecial = "3.Habilitat especial";
                const string defensaMonstre = "El monstre es defensa i rep només ", defensaArquera ="L'arquera es defensa i rep només ", defensaBarbaro = "El barbar es defensa i rep només ", defensaMaga = "La maga es defensa i rep només ", defensaDruida = "El druida es defensa i rep només ", danyGen = " de dany", dany = "ataca al Monstre amb ", danyAtacMonstre = "ataca amb ", restHp = "Vida restant de ", prote = "es protegeix i augmenta la seva defensa x2 pel pròxim atac", coolDown = "L'habilitat especial esta en refredament, espera a que passin 5 torns.  Torns actuals: ", stNoqMonstre = "El monstre esta noquejat i no podra atacar durant aquest torn"; //acciones switch
                int turn = 1, decArquera = 0, decBarbaro = 0, decMaga = 0, decDruida = 0; //decisiones de turnos
                int countHabArquera = 6, countHabBarbaro = 6, countHabMaga = 6, countHabDruida = 6; //habilidades especiales contadores
                int mortA = 0, mortB = 0, mortM = 0, mortD = 0; //contador para mensaje muerte
                
                int noqMonstre = 0, defHabBarbaro = 0, intents = 3;
                const string stHab = "activa la seva habilitat especial i ", stHabArquera = "durant 2 torns el Monstre no podrà atacar", stHabBarbaro = "augmenta la seva defensa durant 3 torns", stHabMaga = "dispara una bola de foc i fa ", stHabDruida = "cura 500 de vida a ", stHabDruidaError = "No pots curar la vida si esta al màxim", stCura = "cura ", stVida = " de vida a ", hpActual = "Vida actual ", stHabDefBarb = "El bàrbar es defensa i no rep dany!"; //Habilidades especiales
                float memArquera = atacArquera, memBarbaro = atacBarbaro, memMaga = atacMaga, memDruida = atacDruida, memMonstre = atacMonstre, danyHabMaga = atacMaga * 3; //memoria valors atac personatges
                float defMemArq = defArquera, defMemBarb = defBarbaro, defMemMaga = defMaga, defMemDruida = defDruida; //memoria valors defensa personatges
                float hpMemArq = hpArquera, hpMemBarb = hpBarbaro, hpMemMaga = hpMaga, hpMemDruida = hpDruida; //memoria valors vida personatges
                float stHpMemArq = 0, stHpMemBarb = 0, stHpMemMaga = 0, stHpMemDruida = 0; //memoria vida 2 (per printar misatges)

                while ((hpArquera > 0 || hpBarbaro > 0 || hpMaga > 0 || hpDruida > 0) && hpMonstre > 0 && intents > 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Torn " + turn + ":");
                    Console.ResetColor();
                    Console.WriteLine();
                    //torn arquera
                    if (hpArquera > 0 && hpMonstre > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine();
                        Console.WriteLine(arquera + selAccio);
                        Console.WriteLine(atacar);
                        Console.WriteLine(protegirse);
                        Console.WriteLine(habEspecial);
                        Console.ResetColor();
                        decArquera = Convert.ToInt16(Console.ReadLine());
                        while ((decArquera < 1 || decArquera > 3) && intents > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(errorValors);
                            Console.ResetColor();
                            Console.WriteLine();
                            intents--;
                            if (intents > 0)
                            {
                                decArquera = Convert.ToInt16(Console.ReadLine());
                            }
                        }
                        switch (decArquera)
                        {
                            case 1:
                                atacArquera = atacArquera * defMonstre;
                                hpMonstre = hpMonstre - atacArquera;
                                Console.WriteLine(arquera + dany + memArquera + danyGen);
                                Console.WriteLine(defensaMonstre + atacArquera + danyGen);
                                Console.WriteLine(restHp + monstre + hpMonstre);
                                break;
                            case 2:
                                defArquera = defArquera / 2;
                                Console.WriteLine(arquera + prote);
                                break;
                            case 3:
                                if (countHabArquera >= 5)
                                {
                                    Console.WriteLine(arquera + stHab + stHabArquera);
                                    noqMonstre = 2;
                                    countHabArquera = 0;
                                }
                                else
                                {
                                    Console.WriteLine(coolDown + countHabArquera);
                                }
                                break;
                        }
                        countHabArquera++;
                        atacArquera = memArquera;
                    }
                    //torn barbaro
                    if ((hpBarbaro > 0 && hpMonstre > 0) && intents > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine();
                        Console.WriteLine(barbaro + selAccio);
                        Console.WriteLine(atacar);
                        Console.WriteLine(protegirse);
                        Console.WriteLine(habEspecial);
                        Console.ResetColor();
                        decBarbaro = Convert.ToInt16(Console.ReadLine());
                        while ((decBarbaro < 1 || decBarbaro > 3) && intents > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(errorValors);
                            Console.ResetColor();
                            Console.WriteLine();
                            intents--;
                            if (intents > 0)
                            {
                                decBarbaro = Convert.ToInt16(Console.ReadLine());

                            }
                        }
                        switch (decBarbaro)
                        {
                            case 1:
                                atacBarbaro = atacBarbaro * defMonstre;
                                hpMonstre = hpMonstre - atacBarbaro;
                                Console.WriteLine(barbaro + dany + memBarbaro + danyGen);
                                Console.WriteLine(defensaMonstre + atacBarbaro + danyGen);
                                Console.WriteLine(restHp + monstre + hpMonstre);
                                break;
                            case 2:
                                defBarbaro = defBarbaro / 2;
                                Console.WriteLine(barbaro + prote);
                                break;
                            case 3:
                                if (countHabBarbaro >= 5)
                                {
                                    Console.WriteLine(barbaro + stHab + stHabBarbaro);
                                    defHabBarbaro = 3;
                                    countHabBarbaro = 0;
                                }
                                else
                                {
                                    Console.WriteLine(coolDown + countHabBarbaro);
                                }
                                break;
                        }
                        countHabBarbaro++;
                        atacBarbaro = memBarbaro;
                    }
                    //Torn Maga
                    if ((hpMaga > 0 && hpMonstre > 0) && intents > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine();
                        Console.WriteLine(maga + selAccio);
                        Console.WriteLine(atacar);
                        Console.WriteLine(protegirse);
                        Console.WriteLine(habEspecial);
                        Console.ResetColor();
                        decMaga = Convert.ToInt16(Console.ReadLine());
                        while ((decMaga < 1 || decMaga > 3) && intents > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(errorValors);
                            Console.ResetColor();
                            Console.WriteLine();
                            intents--;
                            if (intents > 0)
                            {
                                decMaga = Convert.ToInt16(Console.ReadLine());
                            }
                        }
                        switch (decMaga)
                        {
                            case 1:
                                atacMaga = atacMaga * defMonstre;
                                hpMonstre = hpMonstre - atacMaga;
                                Console.WriteLine(maga + dany + memMaga + danyGen);
                                Console.WriteLine(defensaMonstre + atacMaga + danyGen);
                                Console.WriteLine(restHp + monstre + hpMonstre);
                                break;
                            case 2:
                                defMaga = defMaga / 2;
                                Console.WriteLine(maga + prote);
                                break;
                            case 3:
                                if (countHabMaga >= 5)
                                {
                                    atacMaga = (atacMaga * 3) * defMonstre;
                                    hpMonstre = hpMonstre - atacMaga;
                                    Console.WriteLine(maga + stHab + stHabMaga + danyHabMaga + danyGen);
                                    Console.WriteLine(defensaMonstre + atacMaga + danyGen);
                                    Console.WriteLine(restHp + monstre + hpMonstre);
                                    countHabMaga = 0;
                                }
                                else
                                {
                                    Console.WriteLine(coolDown + countHabMaga);
                                }
                                break;
                        }
                        countHabMaga++;
                        atacMaga = memMaga;
                    }
                    //Torn Druida
                    if ((hpDruida > 0 && hpMonstre > 0) && intents > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine();
                        Console.WriteLine(druida + selAccio);
                        Console.WriteLine(atacar);
                        Console.WriteLine(protegirse);
                        Console.WriteLine(habEspecial);
                        Console.ResetColor();
                        decDruida = Convert.ToInt16(Console.ReadLine());
                        while ((decDruida < 1 || decDruida > 3) && intents >0 )
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(errorValors);
                            Console.ResetColor();
                            Console.WriteLine();
                            intents--;
                            if (intents > 0)
                            {
                                decDruida = Convert.ToInt16(Console.ReadLine());
                            }
                        }
                        switch (decDruida)
                        {
                            case 1:
                                atacDruida = atacDruida * defMonstre;
                                hpMonstre = hpMonstre - atacDruida;
                                Console.WriteLine(druida + dany + memDruida + danyGen);
                                Console.WriteLine(defensaMonstre + atacDruida + danyGen);
                                Console.WriteLine(restHp + monstre + hpMonstre);
                                break;
                            case 2:
                                defDruida = defDruida / 2;
                                Console.WriteLine(druida + prote);
                                break;
                            case 3:
                                if (countHabDruida >= 5) //CURA HABILITAT DRUIDA
                                {
                                    if (hpArquera < hpMemArq ) //curar arquera
                                    {
                                        if (hpArquera >= hpMemArq - 500)
                                        {
                                            stHpMemArq = -(hpArquera - hpMemArq);
                                            hpArquera = hpArquera + (hpMemArq - hpArquera);
                                            Console.WriteLine(druida + stHab + stCura + stHpMemArq + stVida + arquera);
                                            Console.WriteLine(hpActual + arquera + ": " + hpArquera);
                                        }
                                        else if (hpArquera < hpMemArq - 500)
                                        {
                                            hpArquera = hpArquera + 500;
                                            Console.WriteLine(druida + stHab + stHabDruida + arquera);
                                            Console.WriteLine(hpActual + arquera + ": " + hpArquera);
                                        }
                                    }
                                    else if (hpArquera == hpMemArq)
                                    { 
                                        Console.WriteLine(arquera + ": " + stHabDruidaError);
                                    }
                                    Console.WriteLine();
                                    if (hpBarbaro < hpMemBarb) //curar barbaro
                                    {
                                        if (hpBarbaro >= hpMemBarb - 500)
                                        {
                                            stHpMemBarb = -(hpBarbaro - hpMemBarb);
                                            hpBarbaro = hpBarbaro + (hpMemBarb - hpBarbaro);
                                            Console.WriteLine(druida + stHab + stCura + stHpMemBarb + stVida + barbaro);
                                            Console.WriteLine(hpActual + barbaro + ": " + hpBarbaro);
                                        }
                                        else if (hpBarbaro < hpMemBarb - 500)
                                        {
                                            hpBarbaro = hpBarbaro + 500;
                                            Console.WriteLine(druida + stHab + stHabDruida + barbaro);
                                            Console.WriteLine(hpActual + barbaro + ": " + hpBarbaro);
                                        }
                                    }
                                    else if (hpBarbaro == hpMemBarb)
                                    {
                                        Console.WriteLine(barbaro + ": " + stHabDruidaError);
                                    }
                                    Console.WriteLine();
                                    if (hpMaga < hpMemMaga) //curar maga
                                    {
                                        if (hpMaga >= hpMemMaga - 500)
                                        {
                                            stHpMemMaga = -(hpMaga - hpMemMaga);
                                            hpMaga = hpMaga + (hpMemMaga - hpMaga);
                                            Console.WriteLine(druida + stHab + stCura + stHpMemMaga + stVida + maga);
                                            Console.WriteLine(hpActual + maga + ": " + hpMaga);
                                        }
                                        else if (hpMaga < hpMemMaga - 500)
                                        {
                                            hpMaga = hpMaga + 500;
                                            Console.WriteLine(druida + stHab + stHabDruida + maga);
                                            Console.WriteLine(hpActual + barbaro + ": " + hpMaga);
                                        }
                                    }
                                    else if (hpMaga == hpMemMaga)
                                    {
                                        Console.WriteLine(maga + ": " + stHabDruidaError);
                                    }
                                    Console.WriteLine();
                                    if (hpDruida < hpMemDruida) //curar druida
                                    {
                                        if (hpDruida >= hpMemDruida - 500)
                                        {
                                            stHpMemDruida = -(hpDruida - hpMemDruida);
                                            hpDruida = hpDruida + (hpMemDruida - hpDruida);
                                            Console.WriteLine(druida + stHab + stCura + stHpMemDruida + stVida + druida);
                                            Console.WriteLine(hpActual + druida + ": " + hpDruida);
                                        }
                                        else if (hpDruida < hpMemDruida - 500)
                                        {
                                            hpDruida = hpDruida + 500;
                                            Console.WriteLine(druida + stHab + stHabDruida + druida);
                                            Console.WriteLine(hpActual + druida + ": " + hpDruida);
                                        }
                                    }
                                    else if (hpDruida == hpMemDruida)
                                    {
                                        Console.WriteLine(druida + ": " + stHabDruidaError);
                                    }
                                    Console.WriteLine();
                                    countHabDruida = 0;
                                }
                                else
                                {
                                    Console.WriteLine(coolDown + countHabDruida);
                                }
                                break;
                        }
                        countHabDruida++;
                        atacDruida = memDruida;
                    }
                    Console.WriteLine();
                    if ((hpMonstre > 0 && noqMonstre == 0) && intents > 0) //ATAC MONSTRE NO NOQUEJAT
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        if (hpArquera>0) 
                        {
                            atacMonstre = atacMonstre * defArquera; //ATAC A ARQUERA
                            hpArquera = hpArquera - atacMonstre;
                            Console.WriteLine(monstre + danyAtacMonstre + memMonstre + danyGen);
                            Console.WriteLine(defensaArquera + atacMonstre + danyGen);
                            if (hpArquera<0)
                            {
                                hpArquera = 0;
                                Console.WriteLine(restHp + arquera + hpArquera);
                            }
                            else
                            {
                                Console.WriteLine(restHp + arquera + hpArquera);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            atacMonstre = memMonstre;
                        }
                        if (defHabBarbaro == 0 && hpBarbaro>0) //NO HABILITAT BARBAR
                        {
                            atacMonstre = atacMonstre * defBarbaro;
                            hpBarbaro = hpBarbaro - atacMonstre;
                            Console.WriteLine(monstre + danyAtacMonstre + memMonstre + danyGen);
                            Console.WriteLine(defensaBarbaro + atacMonstre + danyGen);
                            if (hpBarbaro < 0)
                            {
                                hpBarbaro = 0;
                                Console.WriteLine(restHp + barbaro + hpBarbaro);
                            }
                            else
                            {
                                Console.WriteLine(restHp + barbaro + hpBarbaro);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            atacMonstre = memMonstre;
                        }
                        else if (defHabBarbaro > 1 && hpBarbaro>0) //HABILITAT BARBAR
                        {
                            defHabBarbaro--;
                            Console.WriteLine(stHabDefBarb);
                            Console.ReadLine();
                        }
                        if (hpMaga>0)
                        {
                            atacMonstre = atacMonstre * defMaga; //ATAC A MAGA
                            hpMaga = hpMaga - atacMonstre;
                            Console.WriteLine(monstre + danyAtacMonstre + memMonstre + danyGen);
                            Console.WriteLine(defensaMaga + atacMonstre + danyGen);
                            if (hpMaga < 0) 
                            {
                                hpMaga = 0;
                                Console.WriteLine(restHp + maga + hpMaga);
                            }
                            else
                            {
                                Console.WriteLine(restHp + maga + hpMaga);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            atacMonstre = memMonstre;
                        }
                        if (hpDruida>0)
                        {
                            atacMonstre = atacMonstre * defDruida; //ATAC A DRUIDA
                            hpDruida = hpDruida - atacMonstre;
                            Console.WriteLine(monstre + danyAtacMonstre + memMonstre + danyGen);
                            Console.WriteLine(defensaDruida + atacMonstre + danyGen);
                            if (hpDruida < 0)
                            {
                                hpDruida = 0;
                                Console.WriteLine(restHp + druida + hpDruida);
                            }
                            else
                            {
                                Console.WriteLine(restHp + druida + hpDruida);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            atacMonstre = memMonstre;
                        }
                    }
                    else if ((hpMonstre > 0 && noqMonstre > 0) && intents > 0) //MONSTRE NOQUEJAT
                    {
                        Console.WriteLine(stNoqMonstre);
                        Console.ReadLine();
                        noqMonstre--;
                    }
                    Console.ResetColor();
                    if (hpArquera <= 0 && mortA == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mortArquera);
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;

                        //PRINT SCULL
                        GraphicFunc.Skull();

                        Console.ResetColor();
                        Console.ReadLine();
                        mortA++;
                    }
                    if (hpBarbaro <= 0 && mortB == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mortBarbaro);
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;

                        //PRINT SCULL
                        GraphicFunc.Skull();

                        Console.ResetColor();
                        Console.ReadLine();
                        mortB++;
                    }
                    if (hpMaga <= 0 && mortM == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mortMaga);
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;

                        //PRINT SCULL
                        GraphicFunc.Skull();

                        Console.ResetColor();
                        Console.ReadLine();
                        mortM++;
                    }
                    if (hpDruida <= 0 && mortD == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mortDruida);
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;

                        //PRINT SCULL
                        GraphicFunc.Skull();

                        Console.ResetColor();
                        Console.ReadLine();
                        mortD++;
                    }
                    defArquera = defMemArq;
                    defBarbaro = defMemBarb;
                    defMaga = defMemMaga;
                    defDruida = defMemDruida;
                    turn++;
                    Console.ReadLine();
                    Console.Clear();
                }
                if (hpMonstre <= 0)
                {
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    //PRINT WIN
                    GraphicFunc.Win();

                    Console.ResetColor();
                        Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Què vols fer?");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Jugar (0)");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sortir (1)");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    numStart = Convert.ToInt32(Console.ReadLine());
                    while (numStart != 0 && numStart != 1)
                    {
                        countInicial++;
                        if (countInicial >= 3) return;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("El numero a de ser [0] o [1]");
                        numStart = Convert.ToInt32(Console.ReadLine());
                        Console.ResetColor();
                    }
                    countInicial = 0;
                }
                if (hpArquera<=0 && hpBarbaro<=0 && hpMaga<=0 && hpDruida<=0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    //PRINT LOSE MESSAGE
                    GraphicFunc.Lose();

                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Què vols fer?");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Jugar (0)");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sortir (1)");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    numStart = Convert.ToInt32(Console.ReadLine());
                    while (numStart != 0 && numStart != 1)
                    {
                        countInicial++;
                        if (countInicial >= 3) return;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("El numero a de ser [0] o [1]");
                        numStart = Convert.ToInt32(Console.ReadLine());
                        Console.ResetColor();
                    }
                    countInicial = 0;
                }
                if (intents == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(errorsEsgotats);
                    Console.ResetColor();
                    Console.ReadLine();
                    Main();
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sortint del programa");
            Console.ResetColor();
        }
    }
}



