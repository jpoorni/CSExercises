using System;

namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            bool found = false;
            //divide the first string into the substrings of s2's length
            //s1 = "rajarani" , s2 = "an"
            //splitted string =ra ,aj, ja,ar,ra,an   
            for (int i = 0; i <= s1.Length - s2.Length; i++)
            {
                string temp = s1.Substring(i, s2.Length);

                if (temp == s2)
                {
                    found = true;
                    //System.Console.WriteLine(temp);
                    break;
                }
                else
                {
                    found = false;
                }
            }
            return found;
        }


        static void Main(string[] args)
        {
            //string s1 = " poornima maheswaran poorvash";
            //string s2 = "po";
            
            bool found1;

            System.Console.Write("Enter a word/sentence :");
            string s1 = System.Console.ReadLine();
            System.Console.Write("Enter a substring :");
            string s2 = System.Console.ReadLine();

            int len = s2.Length;
            found1 = InString(s1, s2);

            if (found1 == true)
            {
                System.Console.WriteLine("Found");
            }
            else
            {
                System.Console.WriteLine("Not Found");
            }
            
        }
    }
}
