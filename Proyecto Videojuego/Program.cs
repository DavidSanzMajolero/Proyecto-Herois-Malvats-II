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

            const string ParametresVida = "Vida HEROIS: \nARQUERA: [1500-2000] \nBÀRBAR: [3000-3750] \nMAGA: [1100-1500] \nDRUIDA: [2000-2500]";
            const string ParametresAtac = "Atac HEROIS: \nARQUERA: [200-300] \nBÀRBAR: [150-250] \nMAGA: [300-400] \nDRUIDA: [70-120]";
            const string ParametresDefensa = "Defensa HEROIS: \nARQUERA: [25-35]% \nBÀRBAR: [35-45]% \nMAGA: [20-35]% \nDRUIDA: [25-40]%";
            const string ParametresMonstre = "Vida: \n[7000-10000] \nAtac: [300-400] \nDefensa: [20-30]";

            float[] arrayHP = new float[4], arrayAttack = new float[4], arrayDeff = new float[4], arrayMonster = new float[3];
            float numStart, countInicial = 0, dificultselector;

            bool monster = true;
           
            const string monstre = "Monstre ", arquera = "Arquera ", barbaro = "Bàrbar ", maga = "Maga ", druida = "Druida "; //noms strings
            string names;
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
                do
                {
                    Console.WriteLine("Escriu el nom dels 4 personatges");
                    names = Console.ReadLine() ?? "";
                    arrayNombres = StringNames.StringArray(names);

                } while (!StringNames.Comprobation(names) || arrayNombres.Length != 4);

                for (int i = 0; i < arrayNombres.Length; i++)
                {
                    Console.WriteLine(arrayNombres[i]);
                }
                Console.WriteLine("Quin nivell de dificultat vols?");
                Console.WriteLine("1.Fàcil \t2.Dificil \t3.Personalitzat \t4.Random");
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
                        const string Error = "Els valors que has establert no hi són dins dels paràmetres";
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

                for (int i = 0; i<arrayHP.Length; i++)
                {
                    Console.WriteLine(arrayHP[i]);
                }
                for (int i = 0; i < arrayAttack.Length; i++)
                {
                    Console.WriteLine(arrayAttack[i]);
                }
                for (int i = 0; i < arrayDeff.Length; i++)
                {
                    Console.WriteLine(arrayDeff[i]);
                }
                for (int i = 0; i < arrayMonster.Length; i++)
                {
                    Console.WriteLine(arrayMonster[i]);
                }

                Console.ForegroundColor = ConsoleColor.Cyan;

                //START BATTLE
                GraphicFunc.StartBattle();

                Console.ResetColor();
                //variables i constantes batalla
                const string mortArquera = "La arquera a perdut tota la vida i ha mort", mortBarbaro = "El  barbar  a perdut tota la vida i ha mort", mortMaga = "La maga a perdut tota la vida i ha mort", mortDruida = "El  druida  a perdut tota la vida i ha mort"; //mort herois
                const string HpRest = "Vida herois";
                const string errorValors = "Els valors que has escrit estan malament, torna a escriure-ls", errorsEsgotats = "Errors esgotats, reiniciant programa";
                const string selAccio = "Selecciona l'acció", atacar = "1.Atacar", protegirse = "2.Protegirse", habEspecial = "3.Habilitat especial";
                const string defensaMonstre = "El monstre es defensa i rep només ", defensaArquera = "L'arquera es defensa i rep només ", defensaBarbaro = "El barbar es defensa i rep només ", defensaMaga = "La maga es defensa i rep només ", defensaDruida = "El druida es defensa i rep només ", danyGen = " de dany", dany = "ataca al Monstre amb ", danyAtacMonstre = "ataca amb ", restHp = "Vida restant de ", prote = "es protegeix i augmenta la seva defensa x2 pel pròxim atac", coolDown = "L'habilitat especial esta en refredament, espera a que passin 5 torns.  Torns actuals: ", stNoqMonstre = "El monstre esta noquejat i no podra atacar durant aquest torn"; //acciones switch
                const string MissAttack = "¡El ataque falló!", Critical = "¡Golpe crítico!", NormalAttack = "¡Ataque normal!";



                int turn = 1, decArquera = 0, decBarbaro = 0, decMaga = 0, decDruida = 0; //decisiones de turnos
                int countHabArquera = 6, countHabBarbaro = 6, countHabMaga = 6, countHabDruida = 6; //habilidades especiales contadores
                int mortA = 0, mortB = 0, mortM = 0, mortD = 0; //contador para mensaje muerte
                const int minOne = 1, minThree = 3;

                int noqMonstre = 0, defHabBarbaro = 0, intents = 3;
                const string stHab = "activa la seva habilitat especial i ", stHabArquera = "durant 2 torns el Monstre no podrà atacar", stHabBarbaro = "augmenta la seva defensa durant 3 torns", stHabMaga = "dispara una bola de foc i fa ", stHabDruida = "cura 500 de vida a ", stHabDruidaError = "No pots curar la vida si esta al màxim", stCura = "cura ", stVida = " de vida a ", hpActual = "Vida actual ", stHabDefBarb = "El bàrbar es defensa i no rep dany!"; //Habilidades especiales
                float memArquera = arrayAttack[0], memBarbaro = arrayAttack[1], memMaga = arrayAttack[2], memDruida = arrayAttack[3], memMonstre = arrayMonster[1], danyHabMaga = arrayAttack[2] * 3; //memoria valors atac personatges
                float defMemArq = arrayDeff[0], defMemBarb = arrayDeff[1], defMemMaga = arrayDeff[2], defMemDruida = arrayDeff[3]; //memoria valors defensa personatges
                float hpMemArq = arrayHP[0], hpMemBarb = arrayHP[1], hpMemMaga = arrayHP[2], hpMemDruida = arrayHP[3]; //memoria valors vida personatges
                float stHpMemArq = 0, stHpMemBarb = 0, stHpMemMaga = 0, stHpMemDruida = 0; //memoria vida 2 (per printar misatges)

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
                                    Console.WriteLine(arquera + selAccio);
                                    Console.WriteLine(atacar);
                                    Console.WriteLine(protegirse);
                                    Console.WriteLine(habEspecial);
                                    Console.ResetColor();
                                    decArquera = Convert.ToInt16(Console.ReadLine());
                                    while (ModeFunc.Comprobation(decArquera,minOne,minThree) && intents > 0)
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
                                                Console.WriteLine(arquera + dany + memArquera*2 + danyGen);
                                                Console.WriteLine(defensaMonstre + arrayAttack[0] + danyGen);
                                                Console.WriteLine(restHp + monstre + arrayMonster[0]);
                                            }
                                            else
                                            {
                                                Console.WriteLine(NormalAttack);
                                                arrayAttack[0] = Actions.Attack(arrayAttack[0], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[0]);
                                                Console.WriteLine(arquera + dany + memArquera + danyGen);
                                                Console.WriteLine(defensaMonstre + arrayAttack[0] + danyGen);
                                                Console.WriteLine(restHp + monstre + arrayMonster[0]);
                                            }

                                            break;
                                        case 2:
                                            arrayDeff[0] = Actions.Deffense(arrayDeff[0]);
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
                                    arrayAttack[0] = memArquera;
                                }
                                break;

                            case 2:
                                if ((arrayHP[1] > 0 && arrayMonster[0] > 0) && intents > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine();
                                    Console.WriteLine(barbaro + selAccio);
                                    Console.WriteLine(atacar);
                                    Console.WriteLine(protegirse);
                                    Console.WriteLine(habEspecial);
                                    Console.ResetColor();
                                    decBarbaro = Convert.ToInt16(Console.ReadLine());
                                    while (ModeFunc.Comprobation(decBarbaro, minOne, minThree) && intents > 0)
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
                                                Console.WriteLine(barbaro + dany + memBarbaro *2 + danyGen);
                                                Console.WriteLine(defensaMonstre + arrayAttack[1] + danyGen);
                                                Console.WriteLine(restHp + monstre + arrayMonster[0]);
                                            }
                                            else
                                            {
                                                Console.WriteLine(NormalAttack);
                                                arrayAttack[1] = Actions.Attack(arrayAttack[1], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[1]);
                                                Console.WriteLine(barbaro + dany + memBarbaro + danyGen);
                                                Console.WriteLine(defensaMonstre + arrayAttack[1] + danyGen);
                                                Console.WriteLine(restHp + monstre + arrayMonster[0]);
                                            }

                                            break;
                                        case 2:
                                            arrayDeff[1] = Actions.Deffense(arrayDeff[1]);
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
                                    arrayAttack[1] = memBarbaro;
                                }
                                break;

                            case 3:
                                if ((arrayHP[2] > 0 && arrayMonster[0] > 0) && intents > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine();
                                    Console.WriteLine(maga + selAccio);
                                    Console.WriteLine(atacar);
                                    Console.WriteLine(protegirse);
                                    Console.WriteLine(habEspecial);
                                    Console.ResetColor();
                                    decMaga = Convert.ToInt16(Console.ReadLine());
                                    while (ModeFunc.Comprobation(decMaga, minOne, minThree) && intents > 0)
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
                                                Console.WriteLine(maga + dany + memMaga*2 + danyGen);
                                                Console.WriteLine(defensaMonstre + arrayAttack[2] + danyGen);
                                                Console.WriteLine(restHp + monstre + arrayMonster[0]);
                                            }
                                            else
                                            {
                                                Console.WriteLine(NormalAttack);
                                                arrayAttack[2] = Actions.Attack(arrayAttack[2], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[2]);
                                                Console.WriteLine(maga + dany + memMaga + danyGen);
                                                Console.WriteLine(defensaMonstre + arrayAttack[2] + danyGen);
                                                Console.WriteLine(restHp + monstre + arrayMonster[0]);
                                            }
                                            break;
                                        case 2:
                                            arrayDeff[2] = Actions.Deffense(arrayDeff[2]);
                                            Console.WriteLine(maga + prote);
                                            break;
                                        case 3:
                                            if (countHabMaga >= 5)
                                            {
                                                arrayAttack[2] = (arrayAttack[2] * 3) * arrayMonster[2];
                                                arrayMonster[0] = arrayMonster[0] - arrayAttack[2];
                                                Console.WriteLine(maga + stHab + stHabMaga + danyHabMaga + danyGen);
                                                Console.WriteLine(defensaMonstre + arrayAttack[2] + danyGen);
                                                Console.WriteLine(restHp + monstre + arrayMonster[0]);
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
                                    Console.WriteLine(druida + selAccio);
                                    Console.WriteLine(atacar);
                                    Console.WriteLine(protegirse);
                                    Console.WriteLine(habEspecial);
                                    Console.ResetColor();
                                    decDruida = Convert.ToInt16(Console.ReadLine());
                                    while (ModeFunc.Comprobation(decDruida, minOne, minThree) && intents > 0)
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
                                                Console.WriteLine(druida + dany + memDruida*2 + danyGen);
                                                Console.WriteLine(defensaMonstre + arrayAttack[3] + danyGen);
                                                Console.WriteLine(restHp + monstre + arrayMonster[0]);
                                            }
                                            else
                                            {
                                                Console.WriteLine(NormalAttack);
                                                arrayAttack[3] = Actions.Attack(arrayAttack[3], arrayMonster[2]);
                                                arrayMonster[0] = Actions.RestHP(arrayMonster[0], arrayAttack[3]);
                                                Console.WriteLine(druida + dany + memDruida + danyGen);
                                                Console.WriteLine(defensaMonstre + arrayAttack[3] + danyGen);
                                                Console.WriteLine(restHp + monstre + arrayMonster[0]);
                                            }
                                            break;
                                        case 2:
                                            arrayDeff[3] = Actions.Deffense(arrayDeff[3]);
                                            Console.WriteLine(druida + prote);
                                            break;
                                        case 3:
                                            if (countHabDruida >= 5) //CURA HABILITAT DRUIDA
                                            {
                                                if (arrayHP[0] < hpMemArq) //curar arquera
                                                {
                                                    if (arrayHP[0] >= hpMemArq - 500)
                                                    {
                                                        stHpMemArq = - (arrayHP[0] - hpMemArq);
                                                        arrayHP[0] = arrayHP[0] + (hpMemArq - arrayHP[0]);
                                                        Console.WriteLine(druida + stHab + stCura + stHpMemArq + stVida + arquera);
                                                        Console.WriteLine(hpActual + arquera + ": " + arrayHP[0]);
                                                    }
                                                    else if (arrayHP[0] < hpMemArq - 500)
                                                    {
                                                        arrayHP[0] = arrayHP[0] + 500;
                                                        Console.WriteLine(druida + stHab + stHabDruida + arquera);
                                                        Console.WriteLine(hpActual + arquera + ": " + arrayHP[0]);
                                                    }
                                                }
                                                else if (arrayHP[0] == hpMemArq)
                                                {
                                                    Console.WriteLine(arquera + ": " + stHabDruidaError);
                                                }
                                                Console.WriteLine();
                                                if (arrayHP[1] < hpMemBarb) //curar barbaro
                                                {
                                                    if (arrayHP[1] >= hpMemBarb - 500)
                                                    {
                                                        stHpMemBarb = - (arrayHP[1] - hpMemBarb);
                                                        arrayHP[1] = arrayHP[1] + (hpMemBarb - arrayHP[1]);
                                                        Console.WriteLine(druida + stHab + stCura + stHpMemBarb + stVida + barbaro);
                                                        Console.WriteLine(hpActual + barbaro + ": " + arrayHP[1]);
                                                    }
                                                    else if (arrayHP[1] < hpMemBarb - 500)
                                                    {
                                                        arrayHP[1] = arrayHP[1] + 500;
                                                        Console.WriteLine(druida + stHab + stHabDruida + barbaro);
                                                        Console.WriteLine(hpActual + barbaro + ": " + arrayHP[1]);
                                                    }
                                                }
                                                else if (arrayHP[1] == hpMemBarb)
                                                {
                                                    Console.WriteLine(barbaro + ": " + stHabDruidaError);
                                                }
                                                Console.WriteLine();
                                                if (arrayHP[2] < hpMemMaga) //curar maga
                                                {
                                                    if (arrayHP[2] >= hpMemMaga - 500)
                                                    {
                                                        stHpMemMaga = - (arrayHP[2] - hpMemMaga);
                                                        arrayHP[2] = arrayHP[2] + (hpMemMaga - arrayHP[2]);
                                                        Console.WriteLine(druida + stHab + stCura + stHpMemMaga + stVida + maga);
                                                        Console.WriteLine(hpActual + maga + ": " + arrayHP[2]);
                                                    }
                                                    else if (arrayHP[2] < hpMemMaga - 500)
                                                    {
                                                        arrayHP[2] = arrayHP[2] + 500;
                                                        Console.WriteLine(druida + stHab + stHabDruida + maga);
                                                        Console.WriteLine(hpActual + barbaro + ": " + arrayHP[2]);
                                                    }
                                                }
                                                else if (arrayHP[2] == hpMemMaga)
                                                {
                                                    Console.WriteLine(maga + ": " + stHabDruidaError);
                                                }
                                                Console.WriteLine();
                                                if (arrayHP[3] < hpMemDruida) //curar druida
                                                {
                                                    if (arrayHP[3] >= hpMemDruida - 500)
                                                    {
                                                        stHpMemDruida = -(arrayHP[3] - hpMemDruida);
                                                        arrayHP[3] = arrayHP[3] + (hpMemDruida - arrayHP[3]);
                                                        Console.WriteLine(druida + stHab + stCura + stHpMemDruida + stVida + druida);
                                                        Console.WriteLine(hpActual + druida + ": " + arrayHP[3]);
                                                    }
                                                    else if (arrayHP[3] < hpMemDruida - 500)
                                                    {
                                                        arrayHP[3] = arrayHP[3] + 500;
                                                        Console.WriteLine(druida + stHab + stHabDruida + druida);
                                                        Console.WriteLine(hpActual + druida + ": " + arrayHP[3]);
                                                    }
                                                }
                                                else if (arrayHP[3] == hpMemDruida)
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
                                }
                                countHabDruida++;
                                arrayAttack[3] = memDruida;
                            break;
                        }  
                    }
                    Console.WriteLine();
                    if ((arrayMonster[0] > 0 && noqMonstre == 0) && intents > 0) //ATAC MONSTRE NO NOQUEJAT
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        if (arrayHP[0] > 0)
                        {
                            arrayMonster[1] = Actions.Attack(arrayMonster[1], arrayDeff[0]); 
                            arrayHP[0] = Actions.RestHP(arrayHP[0], arrayMonster[1]);
                            Console.WriteLine(monstre + danyAtacMonstre + memMonstre + danyGen);
                            Console.WriteLine(defensaArquera + arrayMonster[1] + danyGen);
                            if (arrayHP[0] < 0)
                            {
                                arrayHP[0] = 0;
                                Console.WriteLine(restHp + arquera + arrayHP[0]);
                            }
                            else
                            {
                                Console.WriteLine(restHp + arquera + arrayHP[0]);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            arrayMonster[1] = memMonstre;
                        }
                        if (defHabBarbaro == 0 && arrayHP[1] > 0) //NO HABILITAT BARBAR
                        {
                            arrayMonster[1] = Actions.Attack(arrayMonster[1],arrayDeff[1]);
                            arrayHP[1] = Actions.RestHP(arrayHP[1], arrayMonster[1]);
                            Console.WriteLine(monstre + danyAtacMonstre + memMonstre + danyGen);
                            Console.WriteLine(defensaBarbaro + arrayMonster[1] + danyGen);
                            if (arrayHP[1] < 0)
                            {
                                arrayHP[1] = 0;
                                Console.WriteLine(restHp + barbaro + arrayHP[1]);
                            }
                            else
                            {
                                Console.WriteLine(restHp + barbaro + arrayHP[1]);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            arrayMonster[1] = memMonstre;
                        }
                        else if (defHabBarbaro > 1 && arrayHP[1] > 0) //HABILITAT BARBAR
                        {
                            defHabBarbaro--;
                            Console.WriteLine(stHabDefBarb);
                            Console.ReadLine();
                        }
                        if (arrayHP[2] > 0)
                        {
                            arrayMonster[1] = Actions.Attack(arrayMonster[1], arrayDeff[2]);
                            arrayHP[2] = Actions.RestHP(arrayHP[2], arrayMonster[1]);
                            Console.WriteLine(monstre + danyAtacMonstre + memMonstre + danyGen);
                            Console.WriteLine(defensaMaga + arrayMonster[1] + danyGen);
                            if (arrayHP[2] < 0)
                            {
                                arrayHP[2] = 0;
                                Console.WriteLine(restHp + maga + arrayHP[2]);
                            }
                            else
                            {
                                Console.WriteLine(restHp + maga + arrayHP[2]);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            arrayMonster[1] = memMonstre;
                        }
                        if (arrayHP[3] > 0)
                        {
                            arrayMonster[1] = Actions.Attack(arrayMonster[1], arrayDeff[3]);
                            arrayHP[3] = Actions.RestHP(arrayHP[3], arrayMonster[1]);
                            Console.WriteLine(monstre + danyAtacMonstre + memMonstre + danyGen);
                            Console.WriteLine(defensaDruida + arrayMonster[1] + danyGen);
                            if (arrayHP[3] < 0)
                            {
                                arrayHP[3] = 0;
                                Console.WriteLine(restHp + druida + arrayHP[3]);
                            }
                            else
                            {
                                Console.WriteLine(restHp + druida + arrayHP[3]);
                            }
                            Console.WriteLine();
                            Console.ReadLine();
                            arrayMonster[1] = memMonstre;
                        }
                    }
                    else if ((arrayMonster[0] > 0 && noqMonstre > 0) && intents > 0) //MONSTRE NOQUEJAT
                    {
                        Console.WriteLine(stNoqMonstre);
                        Console.ReadLine();
                        noqMonstre--;
                    }

                    float[] sortTemp = new float [arrayHP.Length];

                    for (int i = 0; i < arrayHP.Length; i++)
                    {
                        sortTemp[i] = arrayHP[i];
                    }

                    sortTemp = Actions.ArraySort(sortTemp);

                    Console.WriteLine(HpRest);

                    for (int i = 0; i< sortTemp.Length; i++)
                    {
                        Console.WriteLine(sortTemp[i]);
                    }

                    Console.ReadLine();

                    Console.ResetColor();
                    if (arrayHP[0] <= 0 && mortA == 0)
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
                    if (arrayHP[1] <= 0 && mortB == 0)
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
                    if (arrayHP[2] <= 0 && mortM == 0)
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
                    if (arrayHP[3] <= 0 && mortD == 0)
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
                    if (arrayHP[0] <= 0 && arrayHP[1] <= 0 && arrayHP[2] <= 0 && arrayHP[3] <= 0)
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
}



