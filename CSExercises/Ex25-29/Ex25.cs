using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int Number = 0, Fact = 1;

            System.Console.Write("Enter a number :");
            Number = System.Convert.ToInt32(System.Console.ReadLine());

            for (int i = 1 ; i <= Number;i++)
            {
                Fact = Fact * i;
            }

            System.Console.WriteLine(Fact);
        }
    }
}
