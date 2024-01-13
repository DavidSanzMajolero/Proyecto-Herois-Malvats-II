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
        
    }
}
//defArquera = 1 - (defArquera / 100); //defensa del monstre en valor percentual
