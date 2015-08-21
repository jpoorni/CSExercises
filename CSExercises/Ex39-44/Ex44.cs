using System;

namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                char temp;

                temp = Convert.ToChar(s.Substring(i, 1));
                if (temp == c1) temp = c2;
                result = result + temp;
            }
                return result;
        }


        public static void Main(string[] args)
        {
            //string s1 = "po porp";
            //char c1 = 'p';
            //char c2 = 'P';

            System.Console.Write("Enter a word / phrase :");
            string s1 = System.Console.ReadLine();
            System.Console.Write("Character to look for :");
            char c1 = System.Convert.ToChar(System.Console.ReadLine());
            System.Console.Write("Character to change :");
            char c2 = System.Convert.ToChar(System.Console.ReadLine());

            //System.Console.WriteLine(s1);
            string output = Substitute(s1, c1, c2);
            System.Console.WriteLine("Changed word/phrase : {0}",output);
        }
    }
}
