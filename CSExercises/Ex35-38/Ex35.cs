namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            //string s = "Poornima Poorvash";
            string s;
            int count = 0;

            System.Console.Write("Please enter a phrase :");
            s = System.Console.ReadLine();
            string[] vowels = new string[5] { "a","e", "i", "o", "u" };
            string temp = "";

            for (int j = 0; j < s.Length;j++)
            {
                temp = s.Substring(j,1);
                for (int i = 0; i < vowels.Length; i++)
                {
                    if (temp.ToLower() ==  vowels[i]) 
                    {
                        count++;
                    }
                }
            }
            System.Console.WriteLine("Total number of Vowels : {0}", count);
        }
    }
}
