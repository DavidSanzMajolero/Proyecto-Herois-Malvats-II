using FightLibrary;
using Graphs;
using ModeFunctions;
using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameProject
{
    class SanzDavidCode
    {
        public static void Main()
        {
            const int minVidaArquera = 1500, maxVidaArquera = 2000, minAtacArquera = 200, maxAtacArquera = 300, minDefensaArquera = 25, maxDefensaArquera = 35;
            const int minVidaBarbaro = 3000, maxVidaBarbaro = 3750, minAtacBarbaro = 150, maxAtacBarbaro = 250, minDefensaBarbaro = 35, maxDefensaBarbaro = 45;
            const int minVidaMaga = 1100, maxVidaMaga = 1500, minAtacMaga = 300, maxAtacMaga = 400, minDefensaMaga = 20, maxDefensaMaga = 35;
            const int minVidaDruida = 2000, maxVidaDruida = 2500, minAtacDruida = 70, maxAtacDruida = 120, minDefensaDruida = 25, maxDefensaDruida = 40;
            const int minVidaMonstre = 7000, maxVidaMonstre = 10000, minAtacMonstre = 300, maxAtacMonstre = 400, minDefensaMonstre = 20, maxDefensaMonstre = 30;

            const string Error01 = "El numero a de ser [0] o [1]";
            const string ParametresVida = "Vida HEROIS: \nARQUERA: [1500-2000] \nBÀRBAR: [3000-3750] \nMAGA: [1100-1500] \nDRUIDA: [2000-2500]";
            const string ParametresAtac = "Atac HEROIS: \nARQUERA: [200-300] \nBÀRBAR: [150-250] \nMAGA: [300-400] \nDRUIDA: [70-120]";
            const string ParametresDefensa = "Defensa HEROIS: \nARQUERA: [25-35]% \nBÀRBAR: [35-45]% \nMAGA: [20-35]% \nDRUIDA: [25-40]%";
            const string ParametresMonstre = "Vida: \n[7000-10000] \nAtac: [300-400] \nDefensa: [20-30]";
            const string CreateCharacters = "Perfecte. Comencem a crear personatges!", AskNames = "Escriu el nom dels 4 personatges";
            const string ChooseDifficult = "Quin nivell de dificultat vols?", Difficults = "1.Fàcil \t2.Dificil \t3.Personalitzat \t4.Random";
            const string Error = "Els valors que has establert no hi són dins dels paràmetres", Leave = "Sortint del programa";
            const string Choose = "Què vols fer?", Play = "1.Jugar", LeaveGame = "0.Sortir", CharacterCreated = "Els personatges creats son:";

            float[] arrayHP = new float[4], arrayAttack = new float[4], arrayDeff = new float[4], arrayMonster = new float[3];
            float numStart, countInicial = 0, dificultselector;

            bool monster = true;
            string[] CharacterNames = {"Arquera", "Bárbaro", "Maga", "Druida"};
            const string monstre = "Monstre "; 
            string names;
            string[] arrayNombres;


            GraphicFunc.DrawWelcome();
            numStart = Convert.ToInt32(Console.ReadLine());
            while (numStart != 0 && numStart != 1)
            {
                countInicial++;
                if (countInicial >= 3) return;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(Error01);
                numStart = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
            }

            countInicial = 0;
            while (numStart == 0)
            {
                Console.Clear();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(CreateCharacters);
                Console.ReadKey();
                do
                {
                    Console.WriteLine(AskNames);
                    Console.ResetColor();
                    names = Console.ReadLine() ?? "";
                    arrayNombres = StringNames.StringArray(names);

                } while (!StringNames.Comprobation(names) || arrayNombres.Length != 4);
                Console.WriteLine(CharacterCreated);
                for (int i = 0; i < arrayNombres.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(CharacterNames[i]);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(arrayNombres[i]);
                    Console.WriteLine();
                    Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ChooseDifficult);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Difficults);
                Console.ResetColor();
                do
                {
                    dificultselector = Convert.ToInt32(Console.ReadLine());
                } while (dificultselector != 1 && dificultselector != 2 && dificultselector != 3 && dificultselector != 4);
                switch (dificultselector)
                {
                    case 1:
                        arrayHP = ModeFunc.EasyHardMode(maxVidaArquera, maxVidaBarbaro, maxVidaMaga, maxVidaDruida);
                        arrayAttack = ModeFunc.EasyHardMode(maxAtacArquera, maxAtacBarbaro, maxAtacMaga, maxAtacDruida);
                        arrayDeff = ModeFunc.EasyHardMode(maxDefensaArquera, maxDefensaBarbaro, maxDefensaMaga, maxDefensaDruida);
                        arrayMonster = ModeFunc.EasyHardMode(minVidaMonstre, minAtacMonstre, minDefensaMonstre, monster);

                    break;

                    case 2:
                        arrayHP = ModeFunc.EasyHardMode(minVidaArquera, minVidaBarbaro, minVidaMaga, minVidaDruida);
                        arrayAttack = ModeFunc.EasyHardMode(minAtacArquera, minAtacBarbaro, minAtacMaga, minAtacDruida);
                        arrayDeff = ModeFunc.EasyHardMode(minDefensaArquera, minDefensaBarbaro, minDefensaMaga, minDefensaDruida);
                        arrayMonster = ModeFunc.EasyHardMode(maxVidaMonstre, maxAtacMonstre, maxDefensaMonstre, monster);
                    break;

                    case 3:

                        int count = 0, countGen = 0;
                        bool comprobation = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ParametresVida);
                        Console.ResetColor();
                        GraphicFunc.Archer();
                        do
                        {
                            arrayHP[0] = Convert.ToInt32(Console.ReadLine());
                            if (ModeFunc.Comprobation(arrayHP[0], minVidaArquera, maxVidaArquera))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else comprobation = true;
                            if (count == 3)
                            {
                                countGen++;
                                count = 0;
                            }
                        } while (!comprobation && countGen < 3);
                        comprobation = false;
                        count = 0;
                        if (countGen < 3)
                        {
                            GraphicFunc.Barbarian();
                            do
                            {
                                arrayHP[1] = Convert.ToInt32(Console.ReadLine());
                                if (ModeFunc.Comprobation(arrayHP[1], minVidaBarbaro, maxVidaBarbaro))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                            comprobation = false;
                            count = 0;
                        }
                        if (countGen < 3)
                        {
                            GraphicFunc.Mage();
                            do
                            {
                                arrayHP[2] = Convert.ToInt32(Console.ReadLine());
                                if (ModeFunc.Comprobation(arrayHP[2], minVidaMaga, maxVidaMaga))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                            comprobation = false;
                            count = 0;
                        }
                        if (countGen < 3)
                        {
                            GraphicFunc.Druid();
                            do
                            {
                                arrayHP[3] = Convert.ToInt32(Console.ReadLine());
                                if (ModeFunc.Comprobation(arrayHP[3], minVidaDruida, maxVidaDruida))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                        }
                        if (countGen >= 3) Main();
                        else countGen = 0; count = 0; comprobation = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(ParametresAtac);
                        Console.ResetColor();
                        GraphicFunc.Archer();
                        do
                        {
                            arrayAttack[0] = Convert.ToInt32(Console.ReadLine());
                            if (ModeFunc.Comprobation(arrayAttack[0], minAtacArquera, maxAtacArquera))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else comprobation = true;
                            if (count == 3)
                            {
                                countGen++;
                                count = 0;
                            }
                        } while (!comprobation && countGen < 3);
                        comprobation = false;
                        count = 0;
                        if (countGen < 3)
                        {
                            GraphicFunc.Barbarian();
                            do
                            {
                                arrayAttack[1] = Convert.ToInt32(Console.ReadLine());
                                if (ModeFunc.Comprobation(arrayAttack[1], minAtacBarbaro, maxAtacBarbaro))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                            comprobation = false;
                            count = 0;
                        }
                        if (countGen < 3)
                        {
                            GraphicFunc.Mage();
                            do
                            {
                                arrayAttack[2] = Convert.ToInt32(Console.ReadLine());
                                if (ModeFunc.Comprobation(arrayAttack[2], minAtacMaga, maxAtacMaga))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                            comprobation = false;
                            count = 0;
                        }
                        if (countGen < 3)
                        {
                            GraphicFunc.Druid();
                            do
                            {
                                arrayAttack[3] = Convert.ToInt32(Console.ReadLine());
                                if (ModeFunc.Comprobation(arrayAttack[3], minAtacDruida, maxAtacDruida))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                        }
                        if (countGen >= 3) Main();
                        else countGen = 0; count = 0; comprobation = false;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(ParametresDefensa);
                        Console.ResetColor();
                        GraphicFunc.Archer();
                        do
                        {
                            arrayDeff[0] = Convert.ToInt32(Console.ReadLine());
                            if (ModeFunc.Comprobation(arrayDeff[0], minDefensaArquera, maxDefensaArquera))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else comprobation = true;
                            if (count == 3)
                            {
                                countGen++;
                                count = 0;
                            }
                        } while (!comprobation && countGen < 3);
                        comprobation = false;
                        count = 0;
                        if (countGen < 3)
                        {
                            GraphicFunc.Barbarian();
                            do
                            {
                                arrayDeff[1] = Convert.ToInt32(Console.ReadLine());
                                if (ModeFunc.Comprobation(arrayDeff[1], minDefensaBarbaro, maxDefensaBarbaro))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                            comprobation = false;
                            count = 0;
                        }
                        if (countGen < 3)
                        {
                            GraphicFunc.Mage();
                            do
                            {
                                arrayDeff[2] = Convert.ToInt32(Console.ReadLine());
                                if (ModeFunc.Comprobation(arrayDeff[2], minDefensaMaga, maxDefensaMaga))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                            comprobation = false;
                            count = 0;
                        }
                        if (countGen < 3)
                        {
                            GraphicFunc.Druid();
                            do
                            {
                                arrayDeff[3] = Convert.ToInt32(Console.ReadLine());
                                if (ModeFunc.Comprobation(arrayDeff[3], minDefensaDruida, maxDefensaDruida))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                        }
                        if (countGen >= 3) Main();
                        else countGen = 0; count = 0; comprobation = false;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(ParametresMonstre);
                        Console.ResetColor();
                        GraphicFunc.Monster();
                        do
                        {
                            arrayMonster[0] = Convert.ToInt32(Console.ReadLine());
                            if (arrayMonster[0] < minVidaMonstre || arrayMonster[0] > maxVidaMonstre)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(Error);
                                Console.ResetColor();
                                count++;
                            }
                            else comprobation = true;
                            if (count == 3)
                            {
                                countGen++;
                                count = 0;
                            }
                        } while (!comprobation && countGen < 3);
                        comprobation = false;
                        count = 0;
                        if (countGen < 3)
                        {
                            do
                            {
                                arrayMonster[1] = Convert.ToInt32(Console.ReadLine());
                                if (arrayMonster[1] < minAtacMonstre || arrayMonster[1] > maxAtacMonstre)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                            comprobation = false;
                            count = 0;
                        }
                        if (countGen < 3)
                        {
                            do
                            {
                                arrayMonster[2] = Convert.ToInt32(Console.ReadLine());
                                if (arrayMonster[2] < minDefensaMonstre || arrayMonster[2] > maxDefensaMonstre)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(Error);
                                    Console.ResetColor();
                                    count++;
                                }
                                else comprobation = true;
                                if (count == 3)
                                {
                                    countGen++;
                                    count = 0;
                                }
                            } while (!comprobation && countGen < 3);
                            comprobation = false;
                            count = 0;
                        }
                        if (countGen >= 3) Main();
                    break;

                    case 4:
                        arrayHP = ModeFunc.RandomMode(minVidaArquera, maxVidaArquera, minVidaBarbaro, maxVidaBarbaro, minVidaMaga, maxVidaMaga, minVidaDruida, maxVidaDruida);
                        arrayAttack = ModeFunc.RandomMode(minAtacArquera, maxAtacArquera, minAtacBarbaro, maxAtacBarbaro, minAtacMaga, maxAtacMaga, minAtacDruida, maxAtacDruida);
                        arrayDeff = ModeFunc.RandomMode(minDefensaArquera, maxDefensaArquera, minDefensaBarbaro, maxDefensaBarbaro, minDefensaMaga, maxDefensaMaga, minDefensaDruida, maxDefensaDruida);
                        arrayMonster = ModeFunc.RandomMode(minVidaMonstre, maxVidaMonstre, minAtacMonstre, maxAtacMonstre, minDefensaMonstre, maxDefensaMonstre, monster);
                    break;
                }
                
                for (int i = 0; i < arrayDeff.Length; i++)
                {
                    arrayDeff[i] = 1 - (arrayDeff[i] / 100);
                }
                arrayMonster[2] = 1 - (arrayMonster[2] / 100);

                Console.ForegroundColor = ConsoleColor.Cyan;
                GraphicFunc.StartBattle();
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                const string MortArquera = "La arquera a perdut tota la vida i ha mort", MortBarbaro = "El  barbar  a perdut tota la vida i ha mort", MortMaga = "La maga a perdut tota la vida i ha mort", MortDruida = "El  druida  a perdut tota la vida i ha mort";
                const string HpRest = @"  
  ,d88b.d88b,                       ,d88b.d88b,
  88888888888                       88888888888
  `Y8888888Y'  VIDA RESTANT HEROIS  `Y8888888Y' 
    `Y888Y'                           `Y888Y'         
      `Y'                               `Y'
                    ";
                const string Hearts = @"  
  ,d88b.d88b,
  88888888888
  `Y8888888Y'
    `Y888Y'
      `Y'
                    ";
                const string ErrorValors = "Els valors que has escrit estan malament, torna a escriure-ls", ErrorsEsgotats = "Errors esgotats, reiniciant programa";
                const string SelAccio = "Selecciona l'acció", Atacar = "1.Atacar", Protegirse = "2.Protegirse", HabEspecial = "3.Habilitat especial";
                const string DefensaMonstre = "El monstre es defensa i rep només ", DefensaArquera = "L'arquera es defensa i rep només ", DefensaBarbaro = "El barbar es defensa i rep només ", DefensaMaga = "La maga es defensa i rep només ", DefensaDruida = "El druida es defensa i rep només ", DanyGen = " de dany", dany = "ataca al Monstre amb ", DanyAtacMonstre = "ataca amb ", RestHp = "Vida restant de ", prote = "es protegeix i augmenta la seva defensa x2 pel pròxim atac", coolDown = "L'habilitat especial esta en refredament, espera a que passin 5 torns.  Torns actuals: ", stNoqMonstre = "El monstre esta noquejat i no podra Atacar durant aquest torn";
                const string MissAttack = "¡El ataque falló!", Critical = "¡Golpe crítico!", NormalAttack = "¡Ataque normal!";
                const string StHabDefBarb = "El bàrbar es defensa i no rep dany!", StHabArquera = "durant 2 torns el Monstre no podrà Atacar", StHabBarbaro = "augmenta la seva defensa durant 3 torns", StHabMaga = "dispara una bola de foc i fa ", StHabDruida = "cura 500 de vida a ", StHabDruidaError = "No pots curar la vida si esta al màxim", StCura = "cura ", StVida = " de vida a ", HpActual = "Vida actual ", stHab = "activa la seva habilitat especial i ";
                int turn = 1, decArquera = 0, decBarbaro = 0, decMaga = 0, decDruida = 0;
                int countHabArquera = 6, countHabBarbaro = 6, countHabMaga = 6, countHabDruida = 6;
                int mortA = 0, mortB = 0, mortM = 0, mortD = 0;
                const int minOne = 1, minThree = 3;
                int noqMonstre = 0, defHabBarbaro = 0, intents = 3;
                float memArquera = arrayAttack[0], memBarbaro = arrayAttack[1], memMaga = arrayAttack[2], memDruida = arrayAttack[3], memMonstre = arrayMonster[1], danyHabMaga = arrayAttack[2] * 3;
                float defMemArq = arrayDeff[0], defMemBarb = arrayDeff[1], defMemMaga = arrayDeff[2], defMemDruida = arrayDeff[3]; 
                float hpMemArq = arrayHP[0], hpMemBarb = arrayHP[1], hpMemMaga = arrayHP[2], hpMemDruida = arrayHP[3]; 
                float stHpMemArq = 0, stHpMemBarb = 0, stHpMemMaga = 0, stHpMemDruida = 0;
                float[] sortTemp = new float[arrayHP.Length];
                Random random = new Random();

                while ((arrayHP[0] > 0 || arrayHP[1] > 0 || arrayHP[2] > 0 || arrayHP[3] > 0) && arrayMonster[0] > 0 && intents > 0)
                {

                    int[] turns = new int[4];
                    for (int i = 0; i < turns.Length; i++)
                    {
                        int value;
                        do
                        {
                            value = random.Next(1, 5);
                        } while (turns.Contains(value));
                        turns[i] = value;
                    }

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Torn " + turn + ":");
                    Console.ResetColor();
                    Console.WriteLine();
                    for (int i = 0; i < turns.Length && arrayMonster[0] > 0; i++)
                    {
                        switch (turns[i])
                        {
                            case 1:
                                if (arrayHP[0] > 0 && arrayMonster[0] > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine();
                                    Console.WriteLine(arrayNombres[0] + " " + SelAccio);
                                    Console.WriteLine(Atacar);
                                    Console.WriteLine(Protegirse);
                                    Console.WriteLine(HabEspecial);
                                    Console.ResetColor();
                                    decArquera = Convert.ToInt16(Console.ReadLine());
                                    while (ModeFunc.Comprobation(decArquera,minOne,minThree) && intents > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(ErrorValors);
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

                                            if (Actions.RandomProb(5))
                                            {
                                                Console.WriteLine(MissAttack);
                                            }
                                            else if (Actions.RandomProb(10))
                                            {
                                                Console.WriteLine(Critical);
                                                arrayAttack[0] = Actions.Critical(arrayAttack[0]);
                                                arrayAttack[0] = Actions.Attack(arrayAttack[0], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[0]);
                                                Console.WriteLine(arrayNombres[0] + " " + dany + memArquera*2 + DanyGen);
                                                Console.WriteLine(DefensaMonstre + arrayAttack[0] + DanyGen);
                                                Console.WriteLine(RestHp + monstre + arrayMonster[0]);
                                            }
                                            else
                                            {
                                                Console.WriteLine(NormalAttack);
                                                arrayAttack[0] = Actions.Attack(arrayAttack[0], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[0]);
                                                Console.WriteLine(arrayNombres[0] + " " + dany + memArquera + DanyGen);
                                                Console.WriteLine(DefensaMonstre + arrayAttack[0] + DanyGen);
                                                Console.WriteLine(RestHp + monstre + arrayMonster[0]);
                                            }

                                            break;
                                        case 2:
                                            arrayDeff[0] = Actions.Deffense(arrayDeff[0]);
                                            Console.WriteLine(arrayNombres[0] + " " + prote);
                                            break;
                                        case 3:
                                            if (countHabArquera >= 5)
                                            {
                                                Console.WriteLine(arrayNombres[0] + " " + stHab + StHabArquera);
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
                                    arrayAttack[0] = memArquera;
                                }
                                break;

                            case 2:
                                if ((arrayHP[1] > 0 && arrayMonster[0] > 0) && intents > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine();
                                    Console.WriteLine(arrayNombres[1] + " " + SelAccio);
                                    Console.WriteLine(Atacar);
                                    Console.WriteLine(Protegirse);
                                    Console.WriteLine(HabEspecial);
                                    Console.ResetColor();
                                    decBarbaro = Convert.ToInt16(Console.ReadLine());
                                    while (ModeFunc.Comprobation(decBarbaro, minOne, minThree) && intents > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(ErrorValors);
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
                                            if (Actions.RandomProb(5))
                                            {
                                                Console.WriteLine(MissAttack);
                                            }
                                            else if (Actions.RandomProb(10))
                                            {
                                                Console.WriteLine(Critical);
                                                arrayAttack[1] = Actions.Critical(arrayAttack[1]);
                                                arrayAttack[1] = Actions.Attack(arrayAttack[1], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[1]);
                                                Console.WriteLine(arrayNombres[1] + " " + dany + memBarbaro *2 + DanyGen);
                                                Console.WriteLine(DefensaMonstre + arrayAttack[1] + DanyGen);
                                                Console.WriteLine(RestHp + monstre + arrayMonster[0]);
                                            }
                                            else
                                            {
                                                Console.WriteLine(NormalAttack);
                                                arrayAttack[1] = Actions.Attack(arrayAttack[1], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[1]);
                                                Console.WriteLine(arrayNombres[1] + " " + dany + memBarbaro + DanyGen);
                                                Console.WriteLine(DefensaMonstre + arrayAttack[1] + DanyGen);
                                                Console.WriteLine(RestHp + monstre + arrayMonster[0]);
                                            }

                                            break;
                                        case 2:
                                            arrayDeff[1] = Actions.Deffense(arrayDeff[1]);
                                            Console.WriteLine(arrayNombres[1] + " " + prote);
                                            break;
                                        case 3:
                                            if (countHabBarbaro >= 5)
                                            {
                                                Console.WriteLine(arrayNombres[1] + " " + stHab + StHabBarbaro);
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
                                    arrayAttack[1] = memBarbaro;
                                }
                                break;

                            case 3:
                                if ((arrayHP[2] > 0 && arrayMonster[0] > 0) && intents > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine();
                                    Console.WriteLine(arrayNombres[2] + " " + SelAccio);
                                    Console.WriteLine(Atacar);
                                    Console.WriteLine(Protegirse);
                                    Console.WriteLine(HabEspecial);
                                    Console.ResetColor();
                                    decMaga = Convert.ToInt16(Console.ReadLine());
                                    while (ModeFunc.Comprobation(decMaga, minOne, minThree) && intents > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(ErrorValors);
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
                                            if (Actions.RandomProb(5))
                                            {
                                                Console.WriteLine(MissAttack);
                                            }
                                            else if (Actions.RandomProb(10))
                                            {
                                                Console.WriteLine(Critical);
                                                arrayAttack[2] = Actions.Critical(arrayAttack[2]);
                                                arrayAttack[2] = Actions.Attack(arrayAttack[2], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[2]);
                                                Console.WriteLine(arrayNombres[2] + " " + dany + memMaga*2 + DanyGen);
                                                Console.WriteLine(DefensaMonstre + arrayAttack[2] + DanyGen);
                                                Console.WriteLine(RestHp + monstre + arrayMonster[0]);
                                            }
                                            else
                                            {
                                                Console.WriteLine(NormalAttack);
                                                arrayAttack[2] = Actions.Attack(arrayAttack[2], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[2]);
                                                Console.WriteLine(arrayNombres[2] + " " + dany + memMaga + DanyGen);
                                                Console.WriteLine(DefensaMonstre + arrayAttack[2] + DanyGen);
                                                Console.WriteLine(RestHp + monstre + arrayMonster[0]);
                                            }
                                            break;
                                        case 2:
                                            arrayDeff[2] = Actions.Deffense(arrayDeff[2]);
                                            Console.WriteLine(arrayNombres[2] + " " + prote);
                                            break;
                                        case 3:
                                            if (countHabMaga >= 5)
                                            {
                                                arrayAttack[2] = (arrayAttack[2] * 3) * arrayMonster[2];
                                                arrayMonster[0] = arrayMonster[0] - arrayAttack[2];
                                                Console.WriteLine(arrayNombres[2] + " " + stHab + StHabMaga + danyHabMaga + DanyGen);
                                                Console.WriteLine(DefensaMonstre + arrayAttack[2] + DanyGen);
                                                Console.WriteLine(RestHp + monstre + arrayMonster[0]);
                                                countHabMaga = 0;
                                            }
                                            else
                                            {
                                                Console.WriteLine(coolDown + countHabMaga);
                                            }
                                            break;
                                    }
                                    countHabMaga++;
                                    arrayAttack[2] = memMaga;
                                }
                                break;

                            case 4:
                                if ((arrayHP[3] > 0 && arrayMonster[0] > 0) && intents > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine();
                                    Console.WriteLine(arrayNombres[3] + " " + SelAccio);
                                    Console.WriteLine(Atacar);
                                    Console.WriteLine(Protegirse);
                                    Console.WriteLine(HabEspecial);
                                    Console.ResetColor();
                                    decDruida = Convert.ToInt16(Console.ReadLine());
                                    while (ModeFunc.Comprobation(decDruida, minOne, minThree) && intents > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(ErrorValors);
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
                                            if (Actions.RandomProb(5))
                                            {
                                                Console.WriteLine(MissAttack);
                                            }
                                            else if (Actions.RandomProb(10))
                                            {
                                                Console.WriteLine(Critical);
                                                arrayAttack[3] = Actions.Critical(arrayAttack[3]);
                                                arrayAttack[3] = Actions.Attack(arrayAttack[3], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[3]);
                                                Console.WriteLine(arrayNombres[3] + " " + dany + memDruida*2 + DanyGen);
                                                Console.WriteLine(DefensaMonstre + arrayAttack[3] + DanyGen);
                                                Console.WriteLine(RestHp + monstre + arrayMonster[0]);
                                            }
                                            else
                                            {
                                                Console.WriteLine(NormalAttack);
                                                arrayAttack[3] = Actions.Attack(arrayAttack[3], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[3]);
                                                Console.WriteLine(arrayNombres[3] + " " + dany + memDruida + DanyGen);
                                                Console.WriteLine(DefensaMonstre + arrayAttack[3] + DanyGen);
                                                Console.WriteLine(RestHp + monstre + arrayMonster[0]);
                                            }
                                            break;
                                        case 2:
                                            arrayDeff[3] = Actions.Deffense(arrayDeff[3]);
                                            Console.WriteLine(arrayNombres[3] + " " + prote);
                                            break;
                                        case 3:
                                            if (countHabDruida >= 5)
                                            {
                                                if (arrayHP[0] < hpMemArq)
                                                {
                                                    if (arrayHP[0] >= hpMemArq - 500)
                                                    {
                                                        stHpMemArq = - (arrayHP[0] - hpMemArq);
                                                        arrayHP[0] = arrayHP[0] + (hpMemArq - arrayHP[0]);
                                                        Console.WriteLine(arrayNombres[3] + " " + stHab + StCura + stHpMemArq + StVida + arrayNombres[0]);
                                                        Console.WriteLine(HpActual + arrayNombres[0] + " " + ": " + arrayHP[0]);
                                                    }
                                                    else if (arrayHP[0] < hpMemArq - 500)
                                                    {
                                                        arrayHP[0] = arrayHP[0] + 500;
                                                        Console.WriteLine(arrayNombres[3] + " " + stHab + StHabDruida + arrayNombres[0]);
                                                        Console.WriteLine(HpActual + arrayNombres[0] + " " + ": " + arrayHP[0]);
                                                    }
                                                }
                                                else if (arrayHP[0] == hpMemArq)
                                                {
                                                    Console.WriteLine(arrayNombres[0] + " " + ": " + StHabDruidaError);
                                                }
                                                Console.WriteLine();
                                                if (arrayHP[1] < hpMemBarb)
                                                {
                                                    if (arrayHP[1] >= hpMemBarb - 500)
                                                    {
                                                        stHpMemBarb = - (arrayHP[1] - hpMemBarb);
                                                        arrayHP[1] = arrayHP[1] + (hpMemBarb - arrayHP[1]);
                                                        Console.WriteLine(arrayNombres[3] + " " + stHab + StCura + stHpMemBarb + StVida + arrayNombres[1] + " ");
                                                        Console.WriteLine(HpActual + arrayNombres[1] + " " + ": " + arrayHP[1]);
                                                    }
                                                    else if (arrayHP[1] < hpMemBarb - 500)
                                                    {
                                                        arrayHP[1] = arrayHP[1] + 500;
                                                        Console.WriteLine(arrayNombres[3] + " " + stHab + StHabDruida + arrayNombres[1] + " ");
                                                        Console.WriteLine(HpActual + arrayNombres[1] + " " + ": " + arrayHP[1]);
                                                    }
                                                }
                                                else if (arrayHP[1] == hpMemBarb)
                                                {
                                                    Console.WriteLine(arrayNombres[1] + " " + ": " + StHabDruidaError);
                                                }
                                                Console.WriteLine();
                                                if (arrayHP[2] < hpMemMaga)
                                                {
                                                    if (arrayHP[2] >= hpMemMaga - 500)
                                                    {
                                                        stHpMemMaga = - (arrayHP[2] - hpMemMaga);
                                                        arrayHP[2] = arrayHP[2] + (hpMemMaga - arrayHP[2]);
                                                        Console.WriteLine(arrayNombres[3] + " " + stHab + StCura + stHpMemMaga + StVida + arrayNombres[2] + " ");
                                                        Console.WriteLine(HpActual + arrayNombres[2] + " " + ": " + arrayHP[2]);
                                                    }
                                                    else if (arrayHP[2] < hpMemMaga - 500)
                                                    {
                                                        arrayHP[2] = arrayHP[2] + 500;
                                                        Console.WriteLine(arrayNombres[3] + " " + stHab + StHabDruida + arrayNombres[2] + " ");
                                                        Console.WriteLine(HpActual + arrayNombres[1] + " " + ": " + arrayHP[2]);
                                                    }
                                                }
                                                else if (arrayHP[2] == hpMemMaga)
                                                {
                                                    Console.WriteLine(arrayNombres[2] + " " + ": " + StHabDruidaError);
                                                }
                                                Console.WriteLine();
                                                if (arrayHP[3] < hpMemDruida)
                                                {
                                                    if (arrayHP[3] >= hpMemDruida - 500)
                                                    {
                                                        stHpMemDruida = -(arrayHP[3] - hpMemDruida);
                                                        arrayHP[3] = arrayHP[3] + (hpMemDruida - arrayHP[3]);
                                                        Console.WriteLine(arrayNombres[3] + " " + stHab + StCura + stHpMemDruida + StVida + arrayNombres[3] + " ");
                                                        Console.WriteLine(HpActual + arrayNombres[3] + " " + ": " + arrayHP[3]);
                                                    }
                                                    else if (arrayHP[3] < hpMemDruida - 500)
                                                    {
                                                        arrayHP[3] = arrayHP[3] + 500;
                                                        Console.WriteLine(arrayNombres[3] + " " + stHab + StHabDruida + arrayNombres[3] + " ");
                                                        Console.WriteLine(HpActual + arrayNombres[3] + " " + ": " + arrayHP[3]);
                                                    }
                                                }
                                                else if (arrayHP[3] == hpMemDruida)
                                                {
                                                    Console.WriteLine(arrayNombres[3] + " " + ": " + StHabDruidaError);
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
                                }
                                countHabDruida++;
                                arrayAttack[3] = memDruida;
                            break;
                        }  
                    }
                    Console.WriteLine();
                    if ((arrayMonster[0] > 0 && noqMonstre == 0) && intents > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        if (arrayHP[0] > 0)
                        {
                            arrayMonster[1] = Actions.Attack(arrayMonster[1], arrayDeff[0]); 
                            arrayHP[0] = Actions.RestHP(arrayHP[0], arrayMonster[1]);
                            Console.WriteLine(monstre + DanyAtacMonstre + memMonstre + DanyGen);
                            Console.WriteLine(DefensaArquera + arrayMonster[1] + DanyGen);
                            if (arrayHP[0] < 0)
                            {
                                arrayHP[0] = 0;
                                Console.WriteLine(RestHp + arrayNombres[0] + " " + arrayHP[0]);
                            }
                            else
                            {
                                Console.WriteLine(RestHp + arrayNombres[0] + " " + arrayHP[0]);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            arrayMonster[1] = memMonstre;
                        }
                        if (defHabBarbaro == 0 && arrayHP[1] > 0)
                        {
                            arrayMonster[1] = Actions.Attack(arrayMonster[1],arrayDeff[1]);
                            arrayHP[1] = Actions.RestHP(arrayHP[1], arrayMonster[1]);
                            Console.WriteLine(monstre + DanyAtacMonstre + memMonstre + DanyGen);
                            Console.WriteLine(DefensaBarbaro + arrayMonster[1] + DanyGen);
                            if (arrayHP[1] < 0)
                            {
                                arrayHP[1] = 0;
                                Console.WriteLine(RestHp + arrayNombres[1] + " " + arrayHP[1]);
                            }
                            else
                            {
                                Console.WriteLine(RestHp + arrayNombres[1] + " " + arrayHP[1]);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            arrayMonster[1] = memMonstre;
                        }
                        else if (defHabBarbaro > 1 && arrayHP[1] > 0)
                        {
                            defHabBarbaro--;
                            Console.WriteLine(StHabDefBarb);
                            Console.ReadLine();
                        }
                        if (arrayHP[2] > 0)
                        {
                            arrayMonster[1] = Actions.Attack(arrayMonster[1], arrayDeff[2]);
                            arrayHP[2] = Actions.RestHP(arrayHP[2], arrayMonster[1]);
                            Console.WriteLine(monstre + DanyAtacMonstre + memMonstre + DanyGen);
                            Console.WriteLine(DefensaMaga + arrayMonster[1] + DanyGen);
                            if (arrayHP[2] < 0)
                            {
                                arrayHP[2] = 0;
                                Console.WriteLine(RestHp + arrayNombres[2] + " " + arrayHP[2]);
                            }
                            else
                            {
                                Console.WriteLine(RestHp + arrayNombres[2] + " " + arrayHP[2]);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            arrayMonster[1] = memMonstre;
                        }
                        if (arrayHP[3] > 0)
                        {
                            arrayMonster[1] = Actions.Attack(arrayMonster[1], arrayDeff[3]);
                            arrayHP[3] = Actions.RestHP(arrayHP[3], arrayMonster[1]);
                            Console.WriteLine(monstre + DanyAtacMonstre + memMonstre + DanyGen);
                            Console.WriteLine(DefensaDruida + arrayMonster[1] + DanyGen);
                            if (arrayHP[3] < 0)
                            {
                                arrayHP[3] = 0;
                                Console.WriteLine(RestHp + arrayNombres[3] + " " + arrayHP[3]);
                            }
                            else
                            {
                                Console.WriteLine(RestHp + arrayNombres[3] + " " + arrayHP[3]);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            arrayMonster[1] = memMonstre;
                        }
                    }
                    else if ((arrayMonster[0] > 0 && noqMonstre > 0) && intents > 0)
                    {
                        Console.WriteLine(stNoqMonstre);
                        Console.ReadLine();
                        noqMonstre--;
                    }

                    for (int i = 0; i < arrayHP.Length; i++)
                    {
                        sortTemp[i] = arrayHP[i];
                    }
                    sortTemp = Actions.ArraySort(sortTemp);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(HpRest);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    for (int i = 0; i< sortTemp.Length; i++)
                    {
                        Console.WriteLine(Hearts + " " + sortTemp[i]);
                    }
                    Console.ResetColor();
                    Console.ReadLine();

                    Console.ResetColor();
                    if (arrayHP[0] <= 0 && mortA == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(MortArquera);
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;
                        GraphicFunc.Skull();
                        Console.ResetColor();
                        Console.ReadLine();
                        mortA++;
                    }
                    if (arrayHP[1] <= 0 && mortB == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(MortBarbaro);
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;
                        GraphicFunc.Skull();
                        Console.ResetColor();
                        Console.ReadLine();
                        mortB++;
                    }
                    if (arrayHP[2] <= 0 && mortM == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(MortMaga);
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;
                        GraphicFunc.Skull();
                        Console.ResetColor();
                        Console.ReadLine();
                        mortM++;
                    }
                    if (arrayHP[3] <= 0 && mortD == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(MortDruida);
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;
                        GraphicFunc.Skull();
                        Console.ResetColor();
                        Console.ReadLine();
                        mortD++;
                    }
                    arrayDeff[0] = defMemArq;
                    arrayDeff[1] = defMemBarb;
                    arrayDeff[2] = defMemMaga;
                    arrayDeff[3] = defMemDruida;
                    turn++;
                    Console.ReadLine();
                    Console.Clear();
                    if (arrayMonster[0] <= 0)
                    {
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        GraphicFunc.Win();
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Choose);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Play);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(LeaveGame);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        numStart = Convert.ToInt32(Console.ReadLine());
                        while (numStart != 0 && numStart != 1)
                        {
                            countInicial++;
                            if (countInicial >= 3) return;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(Error01);
                            numStart = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                        }
                        countInicial = 0;
                    }
                    if (arrayHP[0] <= 0 && arrayHP[1] <= 0 && arrayHP[2] <= 0 && arrayHP[3] <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        GraphicFunc.Lose();

                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Choose);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Play);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(LeaveGame);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        numStart = Convert.ToInt32(Console.ReadLine());
                        while (numStart != 0 && numStart != 1)
                        {
                            countInicial++;
                            if (countInicial >= 3) return;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(Error01);
                            numStart = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                        }
                        countInicial = 0;
                    }
                    if (intents == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(ErrorsEsgotats);
                        Console.ResetColor();
                        Console.ReadLine();
                        Main();
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(Leave);
                Console.ResetColor();
            }
        }
    }
}