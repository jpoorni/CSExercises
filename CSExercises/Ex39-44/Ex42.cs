using System;

namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            //bool found = false;

            int pos =0;

            //divide the first string into the substrings of s2's length
            //s1 = "rajarani" , s2 = "an"
            //splitted string =ra ,aj, ja,ar,ra,an   
            for (int i = 0; i <= s1.Length - s2.Length; i++)
            {
                string temp = s1.Substring(i, s2.Length);

                if (temp == s2)
                {
                    pos = i;
                    //found = true;
                    //System.Console.WriteLine(temp);
                    break;
                }
                else
                {
                    pos = -1;
                }
            }
            return pos;
        }



        public static void Main(string[] args)
        {
            //string s1 = "Poornima maheswaran";
            //string s2 = "a m1";
            
            System.Console.Write("Enter a word/sentence :");
            string s1 = System.Console.ReadLine();
            System.Console.Write("Enter a substring :");
            string s2 = System.Console.ReadLine();

            int len = s2.Length;

            int position = FindWord(s1, s2);
            System.Console.WriteLine("[" + s1 + "]    :    [" + s2  + "]");
            System.Console.WriteLine("Starting Position : " + position);
        }
    }
}
