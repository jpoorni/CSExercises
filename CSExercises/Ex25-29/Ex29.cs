using System;

//Perfect No

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int no = 0, total = 0;
            System.Console.Write("Enter a number:");
            no = System.Convert.ToInt32(System.Console.ReadLine());

            for (int i=1 ; i < no ; i++)
            {
                if (no % i == 0)
                {
                    total = total + i;
                }
            }

            if (total == no)
            {
                System.Console.WriteLine("{0} is a Perferct no.", no);
            }
            else
            {
                System.Console.WriteLine("{0} is not a Perferct no.", no);
            }
        }
    }
}
