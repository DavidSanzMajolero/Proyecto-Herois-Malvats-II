using Graphs;

namespace ModeFunctions
{
    public static class ModeFunc
    {
        public static float[] EasyHardMode(float m1, float m2, float m3, float m4)
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
        public static float[] CustomizeMode (float min0, float max0, float min1, float max1, float min2, float max2, float min3, float max3)
        {            
            float[] array = new float[4];
            float[] arrayVoid = new float[0];
            int count = 0, countGen = 0;
            bool comprobation = false;
            const string Error = "Els valors que has establert no hi són dins dels paràmetres";
            GraphicFunc.Archer();
            do
            {
                array[0] = Convert.ToInt32(Console.ReadLine());
                if (array[0] < min0 || array[0] > max0)
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
                    array[1] = Convert.ToInt32(Console.ReadLine());
                    if (array[1] < min1 || array[1] > max1)
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
                    array[2] = Convert.ToInt32(Console.ReadLine());
                    if (array[2] < min2 || array[2] > max2)
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
                    array[3] = Convert.ToInt32(Console.ReadLine());
                    if (array[3] < min3 || array[3] > max3)
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
            if (countGen < 3) return array;
            else return arrayVoid;
        }
    }
}
//defArquera = 1 - (defArquera / 100); //defensa del monstre en valor percentual
