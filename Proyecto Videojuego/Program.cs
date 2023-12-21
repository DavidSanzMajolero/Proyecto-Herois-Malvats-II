using System;
namespace GameProject {
    class SanzDavidCode
    {
        static void Main()
        {
            int numStart, count, countGeneral, countInicial = 0;
            //estats personatges
            float hpArquera = 0, defArquera = 0, hpBarbaro = 0, defBarbaro = 0, hpMaga = 0, defMaga = 0, hpDruida = 0, defDruida = 0, hpMonstre = 0, defMonstre = 0, atacArquera = 0, atacBarbaro = 0, atacMaga = 0, atacDruida = 0, atacMonstre = 0;
            //rangs personatges
            const int minVidaArquera = 1500, maxVidaArquera = 2000, minAtacArquera = 180, maxAtacArquera = 300, minDefensaArquera = 25, maxDefensaArquera = 40;
            const int minVidaBarbaro = 3000, maxVidaBarbaro = 3750, minAtacBarbaro = 150, maxAtacBarbaro = 250, minDefensaBarbaro = 35, maxDefensaBarbaro = 45;
            const int minVidaMaga = 1000, maxVidaMaga = 1500, minAtacMaga = 300, maxAtacMaga = 350, minDefensaMaga = 20, maxDefensaMaga = 35;
            const int minVidaDruida = 2000, maxVidaDruida = 2500, minAtacDruida = 70, maxAtacDruida = 120, minDefensaDruida = 25, maxDefensaDruida = 40;
            const int minVidaMonstre = 9000, maxVidaMonstre = 12000, minAtacMonstre = 250, maxAtacMonstre = 4000, minDefensaMonstre = 20, maxDefensaMonstre = 30;
            const string Vida = "Vida", Atac = "Atac", Defensa = "Defensa", Error = "Els valors que has establert no hi són dins dels paràmetres", Intro = "Pressiona INTRO per saltar la pantalla en negre";
            const string monstre = "Monstre ", arquera = "Arquera ", barbaro = "Bàrbar ", maga = "Maga ", druida = "Druida "; //noms strings
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("···························································································");
            Console.WriteLine(":                                                                                         :");
            Console.WriteLine(": ██████╗ ███████╗███╗   ██╗██╗   ██╗██╗███╗   ██╗ ██████╗ ██╗   ██╗████████╗     █████╗  :");
            Console.WriteLine(": ██╔══██╗██╔════╝████╗  ██║██║   ██║██║████╗  ██║██╔════╝ ██║   ██║╚══██╔══╝    ██╔══██╗ :");
            Console.WriteLine(": ██████╔╝█████╗  ██╔██╗ ██║██║   ██║██║██╔██╗ ██║██║  ███╗██║   ██║   ██║       ███████║ :");
            Console.WriteLine(": ██╔══██╗██╔══╝  ██║╚██╗██║╚██╗ ██╔╝██║██║╚██╗██║██║   ██║██║   ██║   ██║       ██╔══██║ :");
            Console.WriteLine(": ██████╔╝███████╗██║ ╚████║ ╚████╔╝ ██║██║ ╚████║╚██████╔╝╚██████╔╝   ██║       ██║  ██║ :");
            Console.WriteLine(": ╚═════╝ ╚══════╝╚═╝  ╚═══╝  ╚═══╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝  ╚═════╝    ╚═╝       ╚═╝  ╚═╝ :");
            Console.WriteLine(":                                                                                         :");
            Console.WriteLine(": ██╗  ██╗███████╗██████╗  ██████╗ ██╗███████╗    ██╗   ██╗███████╗                       :");
            Console.WriteLine(": ██║  ██║██╔════╝██╔══██╗██╔═══██╗██║██╔════╝    ██║   ██║██╔════╝                       :");
            Console.WriteLine(": ███████║█████╗  ██████╔╝██║   ██║██║███████╗    ██║   ██║███████╗                       :");
            Console.WriteLine(": ██╔══██║██╔══╝  ██╔══██╗██║   ██║██║╚════██║    ╚██╗ ██╔╝╚════██║                       :");
            Console.WriteLine(": ██║  ██║███████╗██║  ██║╚██████╔╝██║███████║     ╚████╔╝ ███████║                       :");
            Console.WriteLine(": ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝╚══════╝      ╚═══╝  ╚══════╝                       :");
            Console.WriteLine(":                                                                                         :");
            Console.WriteLine(": ███╗   ███╗ ██████╗ ███╗   ██╗███████╗████████╗██████╗ ███████╗███████╗                 :");
            Console.WriteLine(": ████╗ ████║██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔══██╗██╔════╝██╔════╝                 :");
            Console.WriteLine(": ██╔████╔██║██║   ██║██╔██╗ ██║███████╗   ██║   ██████╔╝█████╗  ███████╗                 :");
            Console.WriteLine(": ██║╚██╔╝██║██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══██╗██╔══╝  ╚════██║                 :");
            Console.WriteLine(": ██║ ╚═╝ ██║╚██████╔╝██║ ╚████║███████║   ██║   ██║  ██║███████╗███████║                 :");
            Console.WriteLine(": ╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝  ╚═╝╚══════╝╚══════╝                 :");
            Console.WriteLine(":                                                                                         :");
            Console.WriteLine("···························································································");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Intro);
            Console.ResetColor();
            Console.ReadLine();
            Console.WriteLine("Obre la terminal per a una millor experiencia...");
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Què vols fer?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jugar (0)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sortir (1)");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(@"
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
            ");
            Console.ResetColor();
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
                count = 0;
                countGeneral = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        bool noacabat = true;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(arquera);
                        Console.ResetColor();
                        Console.WriteLine("          4$$-.                                          ");
                        Console.WriteLine("           4   \".                                       ");
                        Console.WriteLine("           4    ^.                                       ");
                        Console.WriteLine("           4     $                                       ");
                        Console.WriteLine("           4     'b                                      ");
                        Console.WriteLine("           4      \"b.                                   ");
                        Console.WriteLine("           4        $                                    ");
                        Console.WriteLine("           4        $r                                   ");
                        Console.WriteLine("           4        $F                                   ");
                        Console.WriteLine("-$b========0========$b====*P=->>                         ");
                        Console.WriteLine("           4       *$$F                                  ");
                        Console.WriteLine("           4        $$\"                                 ");
                        Console.WriteLine("           4       .$F                                   ");
                        Console.WriteLine("           4       dP                                    ");
                        Console.WriteLine("           4      F                                      ");
                        Console.WriteLine("           4     @                                       ");
                        Console.WriteLine("           4    .                                        ");
                        Console.WriteLine("           J.  .                                         ");
                        Console.WriteLine("          '$$                                            ");
                        while (noacabat)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(Vida + ": [1500-2000]: ");
                            Console.ResetColor();
                            hpArquera = Convert.ToInt32(Console.ReadLine());
                            if (hpArquera < minVidaArquera || hpArquera > maxVidaArquera)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else
                            {
                                bool atok = false;
                                bool dfok = false;
                                while (count < 3 && atok == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(Atac + ": [180-300]: ");
                                    Console.ResetColor();
                                    atacArquera = Convert.ToInt32(Console.ReadLine());
                                    if (atacArquera < minAtacArquera || atacArquera > maxAtacArquera)
                                        {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(Error);
                                        Console.ResetColor();
                                        count++;
                                    }
                                    else atok = true;
                                }
                                while (atok && count < 3 && dfok == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(Defensa + ": [25-40]: ");
                                    Console.ResetColor();
                                    defArquera = Convert.ToInt32(Console.ReadLine());
                                    if (defArquera < minDefensaArquera || defArquera > maxDefensaArquera)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(Error);
                                        Console.ResetColor();
                                        count++;
                                    }
                                    else dfok = true;
                                }
                                if (count < 3) noacabat = false; Console.Clear();
                                defArquera = 1 - (defArquera / 100); //defensa del monstre en valor percentual
                            }
                            if (count >= 3)
                            {
                                count = 0;
                                countGeneral++;
                            }
                            if (countGeneral >= 3) Main();
                        }
                    }
                    else if (i == 1)
                    {
                        count = 0;
                        Console.Clear();
                        bool noacabat = true;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(barbaro);
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("   /\\  |\\");
                        Console.WriteLine(" __)(__) \\");
                        Console.WriteLine("(__{}__   >");
                        Console.WriteLine("   ||  ) /");
                        Console.WriteLine("   ||  |/");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   /\\");
                        Console.WriteLine("  '--'");
                        Console.WriteLine();
                        while (noacabat)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(Vida + ": [3000-3750]: ");
                            Console.ResetColor();
                            hpBarbaro = Convert.ToInt32(Console.ReadLine());
                            if (hpBarbaro < minVidaBarbaro || hpBarbaro > maxVidaBarbaro)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else
                            {
                                bool atok = false;
                                bool dfok = false;
                                while (count < 3 && atok == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(Atac + ": [150-250]: ");
                                    Console.ResetColor();
                                    atacBarbaro = Convert.ToInt32(Console.ReadLine());
                                    if (atacBarbaro < minAtacBarbaro || atacBarbaro > maxAtacBarbaro)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(Error);
                                        Console.ResetColor();
                                        count++;
                                    }
                                    else atok = true;
                                }
                                while (atok && count < 3 && dfok == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(Defensa + ": [35-45]: ");
                                    Console.ResetColor();
                                    defBarbaro = Convert.ToInt32(Console.ReadLine());
                                    if (defBarbaro < minDefensaBarbaro || defBarbaro > maxDefensaBarbaro)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(Error);
                                        Console.ResetColor();
                                        count++;
                                    }
                                    else dfok = true;
                                }
                                if (count < 3) noacabat = false; Console.Clear();
                                defBarbaro = 1 - (defBarbaro / 100); //defensa del monstre en valor percentual
                            }
                            if (count >= 3)
                            {
                                count = 0;
                                countGeneral++;
                            }
                            if (countGeneral >= 3) Main();
                        }
                        Console.WriteLine();
                        Console.Clear();
                        Console.WriteLine("Selecciona un arma pel teu bàrbar");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Fil obscur de Drakthar (+25 atac): Pressiona 1");
                        Console.ResetColor();
                        Console.WriteLine("     ^");
                        Console.WriteLine("    / \\");
                        Console.WriteLine("    ) (");
                        Console.WriteLine("   <   >");
                        Console.WriteLine("    ) (");
                        Console.WriteLine("    | |");
                        Console.WriteLine("    ) (");
                        Console.WriteLine("   <   >");
                        Console.WriteLine("    ) (");
                        Console.WriteLine("    | |");
                        Console.WriteLine("    ) (");
                        Console.WriteLine("   <   >");
                        Console.WriteLine(" .  ) (  .");
                        Console.WriteLine(" |\\_| |_/|");
                        Console.WriteLine("< ¤_ ¤ _¤ >");
                        Console.WriteLine(" |/ \\_/ \\|");
                        Console.WriteLine(" '  [-]  '");
                        Console.WriteLine("    [-]");
                        Console.WriteLine("    [-]");
                        Console.WriteLine("    [-]");
                        Console.WriteLine("   (___)");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fil infinit (+150 vida): Pressiona 2");
                        Console.ResetColor();
                        Console.WriteLine("    ^");
                        Console.WriteLine("   / \\");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   |||");
                        Console.WriteLine("   |||");
                        Console.WriteLine("   |||");
                        Console.WriteLine("   |||");
                        Console.WriteLine("   |||");
                        Console.WriteLine("   |||");
                        Console.WriteLine("   |||");
                        Console.WriteLine("   |||");
                        Console.WriteLine("   |||");
                        Console.WriteLine("_  |||  _");
                        Console.WriteLine("\\\\_|_|_//");
                        Console.WriteLine(" \\_____/");
                        Console.WriteLine("   (x)");
                        Console.WriteLine("   (x)");
                        Console.WriteLine("   (x)");
                        Console.WriteLine();
                        int arma = Convert.ToInt32(Console.ReadLine());
                        while (arma != 1 && arma != 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(Error);
                            Console.ResetColor();
                            arma = Convert.ToInt32(Console.ReadLine());
                        }
                        if (arma == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            atacBarbaro = atacBarbaro + 25;
                            Console.WriteLine("L' atac a augmentat a " + atacBarbaro);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            hpBarbaro = hpBarbaro + 150;
                            Console.WriteLine("La vida a augmentat a " + hpBarbaro);
                            Console.ResetColor();
                        }
                    }
                    else if (i == 2)
                    {
                        count = 0;
                        Console.ReadLine();
                        Console.Clear();
                        bool noacabat = true;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(maga);
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("                   _.-.");
                        Console.WriteLine("                .-'%%~%'.");
                        Console.WriteLine("             _.'%%¨_.'-._\\");
                        Console.WriteLine("           .'%%%%~|      '");
                        Console.WriteLine("          '%¨%%%%%-");
                        Console.WriteLine(".________/_________\\_______.");
                        Console.WriteLine(" ¨¨°¨°¨¨            ¨°¨¨¨°¨");
                        while (noacabat)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(Vida + ": [1000-1500]: ");
                            Console.ResetColor();
                            hpMaga = Convert.ToInt32(Console.ReadLine());
                            if (hpMaga < minVidaMaga || hpMaga > maxVidaMaga)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else
                            {
                                bool atok = false;
                                bool dfok = false;
                                while (count < 3 && atok == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(Atac + ": [300-350]: ");
                                    Console.ResetColor();
                                    atacMaga = Convert.ToInt32(Console.ReadLine());
                                    if (atacMaga < minAtacMaga || atacMaga > maxAtacMaga)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(Error);
                                        Console.ResetColor();
                                        count++;
                                    }
                                    else atok = true;
                                }
                                while (atok && count < 3 && dfok == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(Defensa + ": [20-35]: ");
                                    Console.ResetColor();
                                    defMaga = Convert.ToInt32(Console.ReadLine());
                                    if (defMaga < minDefensaMaga || defMaga > maxDefensaMaga)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(Error);
                                        Console.ResetColor();
                                        count++;
                                    }
                                    else dfok = true;
                                }
                                if (count < 3) noacabat = false; Console.Clear();
                                defMaga = 1 - (defMaga / 100); //defensa del monstre en valor percentual
                            }
                            if (count >= 3)
                            {
                                count = 0;
                                countGeneral++;
                            }
                            if (countGeneral >= 3) Main();
                        }
                    }
                    else if (i == 3)
                    {
                        count = 0;
                        Console.Clear();
                        bool noacabat = true;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(druida);
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine(" .  .  .");
                        Console.WriteLine("/ \\/ \\/ \\");
                        Console.WriteLine("\\_     _/");
                        Console.WriteLine("  \\_ _/");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   | |");
                        Console.WriteLine("   |_|");
                        Console.WriteLine("   ( )");
                        Console.WriteLine("  _/ \\_");
                        Console.WriteLine(" /_____\\");
                        Console.WriteLine();
                        while (noacabat)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(Vida + ": [2000-2500]: ");
                            Console.ResetColor();
                            hpDruida = Convert.ToInt32(Console.ReadLine());
                            if (hpDruida < minVidaDruida || hpDruida > maxVidaDruida)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else
                            {
                                bool atok = false;
                                bool dfok = false;
                                while (count < 3 && atok == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(Atac + ": [70-120]: ");
                                    Console.ResetColor();
                                    atacDruida = Convert.ToInt32(Console.ReadLine());
                                    if (atacDruida < minAtacDruida || atacDruida > maxAtacDruida)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(Error);
                                        Console.ResetColor();
                                        count++;
                                    }
                                    else atok = true;
                                }
                                while (atok && count < 3 && dfok == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(Defensa + ": [25-40]: ");
                                    Console.ResetColor();
                                    defDruida = Convert.ToInt32(Console.ReadLine());
                                    if (defDruida < minDefensaDruida || defDruida > maxDefensaDruida)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(Error);
                                        Console.ResetColor();
                                        count++;
                                    }
                                    else dfok = true;
                                }
                                if (count < 3) noacabat = false; Console.Clear();
                                defDruida = 1 - (defDruida / 100); //defensa del monstre en valor percentual
                            }
                            if (count >= 3)
                            {
                                count = 0;
                                countGeneral++;
                            }
                            if (countGeneral >= 3) Main();
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Tots els personatges han estat creats correctament!");
                Console.WriteLine();
                Console.WriteLine("Estableix les estadistíques del monstre!");
                bool monstreNoAcabat = true;
                count = 0;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
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
                     \( `   <.,../`     `-.._   _,-`
                    ");
                Console.ResetColor();
                while (monstreNoAcabat)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Vida + ": [9000-12000]: ");
                    Console.ResetColor();
                    hpMonstre = Convert.ToInt32(Console.ReadLine());
                    if (hpMonstre < minVidaMonstre || hpMonstre > maxVidaMonstre)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(Error);
                        Console.ResetColor();
                        count++;
                    }
                    else
                    {
                        bool atok = false;
                        bool dfok = false;
                        while (count < 3 && atok == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(Atac + ": [250-400]: ");
                            Console.ResetColor();
                            atacMonstre = Convert.ToInt32(Console.ReadLine());
                            if (atacMonstre < minAtacMonstre || atacMonstre > maxAtacMonstre)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else atok = true;
                        }
                        while (atok && count < 3 && dfok == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(Defensa + ": [20-30]: ");
                            Console.ResetColor();
                            defMonstre = Convert.ToInt32(Console.ReadLine());
                            if (defMonstre < minDefensaMonstre || defMonstre > maxDefensaMonstre)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else dfok = true;
                        }
                        defMonstre = 1 - (defMonstre / 100); //defensa del monstre en valor percentual
                        if (count < 3)
                        {
                            monstreNoAcabat = false;
                            Console.Clear();
                        }
                        else if (count >= 3)
                        {
                            count = 0;
                            countGeneral++;
                        }
                        if (countGeneral >= 3) Main();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
                  ______   ______   .___  ___.  _______ .__   __.   ______  _______ .___  ___.     __          ___         .______        ___   .___________.    ___       __       __          ___       __ 
                 /      | /  __  \  |   \/   | |   ____||  \ |  |  /      ||   ____||   \/   |    |  |        /   \        |   _  \      /   \  |           |   /   \     |  |     |  |        /   \     |  |
                |  ,----'|  |  |  | |  \  /  | |  |__   |   \|  | |  ,----'|  |__   |  \  /  |    |  |       /  ^  \       |  |_)  |    /  ^  \ `---|  |----`  /  ^  \    |  |     |  |       /  ^  \    |  |
                |  |     |  |  |  | |  |\/|  | |   __|  |  . `  | |  |     |   __|  |  |\/|  |    |  |      /  /_\  \      |   _  <    /  /_\  \    |  |      /  /_\  \   |  |     |  |      /  /_\  \   |  |
                |  `----.|  `--'  | |  |  |  | |  |____ |  |\   | |  `----.|  |____ |  |  |  |    |  `----./  _____  \     |  |_)  |  /  _____  \   |  |     /  _____  \  |  `----.|  `----./  _____  \  |__|
                 \______| \______/  |__|  |__| |_______||__| \__|  \______||_______||__|  |__|    |_______/__/     \__\    |______/  /__/     \__\  |__|    /__/     \__\ |_______||_______/__/     \__\ (__)
                ");
                Console.ResetColor();
                //variables i constantes batalla
                const string mortArquera = "La arquera a perdut tota la vida i ha mort", mortBarbaro = "El  barbar  a perdut tota la vida i ha mort", mortMaga = "La maga a perdut tota la vida i ha mort", mortDruida = "El  druida  a perdut tota la vida i ha mort"; //mort herois
                const string errorValors = "Els valors que has escrit estan malament, torna a escriure-ls", errorsEsgotats = "Errors esgotats, reiniciant programa";
                const string selAccio = "Selecciona l'acció", atacar = "1.Atacar", protegirse = "2.Protegirse", habEspecial = "3.Habilitat especial";
                const string defensaMonstre = "El monstre es defensa i rep només ", defensaArquera ="L'arquera es defensa i rep només ", defensaBarbaro = "El barbar es defensa i rep només ", defensaMaga = "La maga es defensa i rep només ", defensaDruida = "El druida es defensa i rep només ", danyGen = " de dany", dany = "ataca al Monstre amb ", danyAtacMonstre = "ataca amb ", restHp = "Vida restant de ", prote = "es protegeix i augmenta la seva defensa x2 pel pròxim atac", coolDown = "L'habilitat especial esta en refredament, espera a que passin 5 torns.  Torns actuals: ", stNoqMonstre = "El monstre esta noquejat i no podra atacar durant aquest torn"; //acciones switch
                int turn = 1, decArquera = 0, decBarbaro = 0, decMaga = 0, decDruida = 0; //decisiones de turnos
                int countHabArquera = 6, countHabBarbaro = 6, countHabMaga = 6, countHabDruida = 6; //habilidades especiales contadores
                int mortA = 0, mortB = 0, mortM = 0, mortD = 0; //contador para mensaje muerte
                long skullCount = 5, timerSkull = 50000000; //timer
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
                        while(skullCount>0)
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
                            while(timerSkull>0)
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
                    Console.WriteLine(@"

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
                    ");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"    
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
                    ");
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
                    Console.WriteLine(@"


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

                    ");
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



//si has leido hasta aqui y te ha gustado el programa, ponme un mensajito positivo :)