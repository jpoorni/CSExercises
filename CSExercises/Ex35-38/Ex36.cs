namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            //string s = "madam1";

            string s;
            string s1 ="";


            System.Console.Write("Enter a word/phrase :");
            s = System.Console.ReadLine();

            for (int i = 0;i<s.Length;i++)
            {
                s1 = s1 + s.Substring((s.Length-i)-1, 1);
            }

            if (s1 == s)
            {
                System.Console.WriteLine("Palindrome");
            }
            else
            {
                System.Console.WriteLine("Not Palindrome");
            }
            
        }
    }
}
