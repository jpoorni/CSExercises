using System;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            //double input = 1.20 , amt = 0;

            double amt = 0;
            System.Console.Write("Enter the amount :");
            double input = System.Convert.ToDouble(System.Console.ReadLine());

            //int hundred = 0 , fifty = 0,twenty = 0,ten = 0,five = 0;
            double[] denominations1 = new double[5] { 100, 50, 20, 10, 5 };
            //string[] denominations = new string[5] {"100c","50c","20c","10c","5c"};

             amt = input * 100.0;

            // option 2
             for (int i = 0; i < denominations1.Length;i++)
             {
                 if (amt >= denominations1[i])
                 {
                     double temp = Convert.ToInt32(Math.Floor(amt / denominations1[i]));
                     amt = amt % denominations1[i];
                     for (int j = 0; j < temp;j++)
                     { 
                         System.Console.WriteLine("{0}", denominations1[i] + "c");
                     }
                 }
             }


            //// option - 1 
           //      if (amt >= 100)
           //      {
           //          hundred = Convert.ToInt32(Math.Floor(amt / 100));
           //          amt = amt % 100;
           //      }
           //if (amt >= 50)
           //{
           //    fifty = Convert.ToInt32(Math.Floor(amt / 50));
           //    amt = amt % 50;
           //}
           //if (amt >= 20)
           //{
           //    twenty = Convert.ToInt32(Math.Floor(amt / 20));
           //    amt = amt % 20;
           //}
           //if (amt >= 10)
           //{
           //    ten = Convert.ToInt32(Math.Floor(amt / 10));
           //    amt = amt % 10;
           //}
           //if (amt >= 5)
           //{
           //    five = Convert.ToInt32(Math.Floor(amt / 5));
           //}


           // // to print 2 hundred : 100c 100c
           // //2 twenty : 20c 20c 
           // //1 ten : 10c

           //for (int i = 0; i < hundred;i++)
           //{
           //    System.Console.WriteLine("{0}", denominations[0]);
           //}

           //for (int i = 0; i < fifty; i++)
           //{
           //    System.Console.WriteLine("{0}", denominations[1]);
           //}

           //for (int i = 0; i < twenty; i++)
           //{
           //    System.Console.WriteLine("{0}", denominations[2]);
           //}

           //for (int i = 0; i < ten; i++)
           //{
           //    System.Console.WriteLine("{0}", denominations[3]);
           //}

           //for (int i = 0; i < five; i++)
           //{
           //    System.Console.WriteLine("{0}", denominations[4]);
           //}
        }
    }
}
