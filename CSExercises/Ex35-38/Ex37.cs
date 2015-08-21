using System;

//title case : poornima maheswaran = Poornima Maheswaran 

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            //string input = "Poornima Maheshwaran is my full name.";

            string input;
            System.Console.Write("Enter a sentence :");
            
            input = System.Console.ReadLine();
            
            string[] s2 = input.Split(new char[] {' ' });

            string titlecase = "";
            for (int i = 0; i < s2.Length; i++)
            {
                  string temp = s2[i];

                  //System.Console.WriteLine(s2[i]);
               
     
                if (temp.Length > 1)
                {
                    temp = temp.ToUpper().Substring(0, 1)
                        + temp.Substring(1, temp.Length - 1);
                    
                    titlecase = titlecase + temp + " ";
                }
                else if (temp.Length == 1)
                {
                    temp = temp.ToUpper().Substring(0, 1);

                    titlecase = titlecase + temp + " ";
                }
            }

            System.Console.WriteLine("\n{0}",titlecase);
        }
    }
}
