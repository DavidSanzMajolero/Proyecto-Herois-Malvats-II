namespace FightLibrary
{
    public class Actions
    {
        public static float Attack(float attack, float defense)
        {
            return attack * defense;
        }
        public static float Deffense (float deffense)
        {
            return deffense / 2;
        }
        public static float RestHP(float hp, float attack)
        {
            return hp - attack;
        }
        public static float [] ArraySort(float [] array) 
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        float temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public static float Critical (float attack)
        {
            return attack * 2;
        }
        public static bool RandomProb(int probabilidad)
        {
            int randomValue = new Random().Next(100);
            return randomValue < probabilidad;
        }
    }
}
