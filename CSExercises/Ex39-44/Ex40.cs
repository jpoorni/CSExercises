using System;
using System.Data.SqlClient;

//square root 1 to 25

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            double dblOutput = 0;

            //System.Console.Write("Enter a no:");
            //intInput = System.Convert.ToInt32(System.Console.ReadLine());
            for (int i = 1; i <= 25;i++)
            { 
                dblOutput = SQT(i);
                System.Console.WriteLine("{0:0.00000}", dblOutput);
            }
        }

        public static double SQT(int y)
        {
            double dblGuessNo;

            Random r = new Random();
            dblGuessNo = r.Next(1, y);
            do
            {
                dblGuessNo = (dblGuessNo + (y / dblGuessNo)) / 2;
                //System.Console.WriteLine(dblGuessNo);
            }while (Math.Abs(y - dblGuessNo * dblGuessNo) > 0.0001);
            //System.Console.WriteLine(dblGuessNo);
            return dblGuessNo;
        }
    }
}

