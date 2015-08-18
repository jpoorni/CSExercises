using System;

namespace CSExercises
{
    public class Ex23b
    {
        public static void Main(string[] args)
        {
            int count = 0, guessNo, secretNo;
            //bool cont = false;

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
                        
                        count = count + 1;
                        guessNo = System.Convert.ToInt32(System.Console.ReadLine());

                        if (secretNo != guessNo)
                        {
                            System.Console.WriteLine("Try again");
                        }

                    } while (secretNo != guessNo);


                    if (count <= 2)
                    {
                        System.Console.WriteLine("You are a wizard");
                    }
                    else if ((count > 2) && (count <= 5))
                    {
                        System.Console.WriteLine("You are a good guess");
                    }
                    else if ((count > 5) && (count <= 8))
                    {
                        System.Console.WriteLine("You are lousy!");
                    }
                }
        }
    }
}
