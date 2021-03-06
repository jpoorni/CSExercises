using System;

//HCF & LCM

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int intA = 0, intB = 0 , TempA = 0, TempB = 0;

            System.Console.Write("Enter A:");
            intA = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter B:");
            intB = System.Convert.ToInt32(System.Console.ReadLine());

            TempA = intA ; //used in LCM
            TempB = intB ; //used in LCM -- (A * B)/HCF
            

            do
            {
                if (intA > intB)
                {
                    intA  = intA - intB;              
                }
                else
                {
                    intB  = intB - intA;
                }
            } while (intA != intB);

            System.Console.WriteLine("HCF :{0}",intA);
            System.Console.WriteLine("LCM :{0}", ((TempA*TempB)/intA));
        }
    }
}
