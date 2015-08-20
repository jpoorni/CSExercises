using System;

//Factorial function

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            long Fact=1;

            for (int i = 1; i <= n; i++)
            {
                Fact = Fact * i;
            }

            return Fact;
        }



        static public void Main(string[] args)
        {
            long lngInputNo = 0, lngOutput = 0;

            System.Console.Write("Enter a number :");
            lngInputNo = System.Convert.ToInt64(System.Console.ReadLine());

            lngOutput = Factorial(lngInputNo);
            System.Console.WriteLine(lngOutput);
        }
    }
}
