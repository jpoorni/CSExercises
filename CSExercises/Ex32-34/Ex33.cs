using System;

//descending order

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] nos = new int[] { 86, 35, 41, 49, 89, 51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};

            int temp = 0;
            for (int i=0 ; i< nos.Length-1;i++)
            {
                for (int j = i + 1; j < nos.Length; j++)
                {
                    if (nos[j] > nos[i])
                    {
                        temp = nos[j];
                        nos[j] = nos[i];
                        nos[i] = temp;
                    }
                }

                System.Console.WriteLine("Pass-{0}",i+1);
                for (int k = 0; k < nos.Length; k++)
                {
                    System.Console.Write("  {0}", nos[k]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
