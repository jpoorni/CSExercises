using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int count = 0, guessNo, secretNo;

            Random r = new Random();
            secretNo = r.Next(0, 10); //0 is included & 10 is excluded, so a number between 0 to 9 is selected
            System.Console.WriteLine(secretNo);

            guessNo = 0;

            if (guessNo < 0 && guessNo >9)
            {
                System.Console.WriteLine("Guess the number between 0 to 9");
            }
            else
            {
                do  
                {
                    System.Console.Write("Guess a no between 0 to 9 :");
                    guessNo = System.Convert.ToInt32(System.Console.ReadLine());
                    count = count + 1;
                }while(secretNo != guessNo);

                System.Console.WriteLine("Congrats..Your guess is correct..");
                System.Console.WriteLine("Guesses you made: {0}",count);
            }
        }
    }
}
