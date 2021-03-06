using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("NO\t\tINVERSE\t\t\tSQUARE ROOT\t\tSQUARE");
            System.Console.WriteLine("-------------------------------------------------------------------------");

            double inv , sqr, sqrt;

            for (int i = 1 ; i <=10 ; i++)
            {
                inv = Math.Round((1.0 / i),3);
                sqrt = Math.Round(Math.Sqrt(i),3) ;
                sqr = Math.Pow(i, 2.0);
                System.Console.WriteLine(" {0:0.0}\t\t{1:0.0###}\t\t\t{2:0.0###}\t\t\t{3:0.0###}", i, inv,sqrt, sqr);

            }
        }
    }
}
