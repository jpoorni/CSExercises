using System;


//prompt the input until u get 88 and then print "lucky u"

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int  intNumber = 0;

            do
            {
                System.Console.Write("Enter number :");
                intNumber = System.Convert.ToInt32(System.Console.ReadLine());
            } while (intNumber != 88);

            if (intNumber == 88)
                System.Console.WriteLine("Lucky you...");
        }
    }
}
