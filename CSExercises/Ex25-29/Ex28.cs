using System;

//Prime or not

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int number, rem = 0;

            System.Console.Write("Enter a Number :");
            number = System.Convert.ToInt32(System.Console.ReadLine());

            if (number >=2 )
            { 
                bool prime = false ;

                for (int i = 2; i < number; i++)
                {
                    rem = number % i;
                    if (rem == 0) 
                    { 
                        prime = true; 
                        break; 
                    }
                }

                if (prime == false) 
                {
                    System.Console.WriteLine("Prime");
                }
                else
                {
                    System.Console.WriteLine("Not Prime");
                }
            }
            if ((number == 1) ||  (number ==0))
            {
                System.Console.WriteLine("1 is neither a prime nor composite");
            }
        }

    }
}
