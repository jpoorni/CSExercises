using System;

//perfect no betweeem 1 to 1000

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int no = 0, total = 0;
            //System.Console.Write("Enter a number:");
            //no = System.Convert.ToInt32(System.Console.ReadLine());

            for (int j = 1; j <= 10000;j++ )
            {
                total = 0;
                no = j;
                for (int i = 1; i < no; i++)
                {
                    if (no % i == 0)
                    {
                        total = total + i;
                    }
                }

            if (total == no)
            {
                System.Console.WriteLine("{0}", no);
            }
        }
      }
   }
}
