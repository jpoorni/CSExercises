namespace CSExercises
{
    public class Ex36B
    {
        public static void Main(string[] args)
        {
            //string s = "Mr. Owl ate my metal worm";
            //string s = "A !saa @@at";

            string s;
            string s3 ="";

            System.Console.Write("Enter a sentence :");
            s = System.Console.ReadLine();

            string[] s2 = s.Split(new char[] { '!', '@', ' ', ',', '#', '$', '%', '^', '&', '*', '(', ')', '-', '{', '}', ':', ';', '<', '>', '[', ']', '|', '.' });

            for (int i = 0; i < s2.Length;i++)
            {
                if (s2[i] != "")
                {
                    s3 = s3 + s2[i];
                }
            }

            //System.Console.WriteLine("new string {0}", s3);

            string reverseString = "";
            for (int i = 0; i < s3.Length; i++)
            {

                reverseString = reverseString + (s3.Substring((s3.Length - i)-1, 1)).ToLower();
            }

            if (reverseString.ToLower() == s3.ToLower())
                System.Console.WriteLine("Palindrome");
            else
                System.Console.WriteLine("Not Palindrome");

            //System.Console.WriteLine("new string {0}",s3);
        }
    }
}
