namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int rem = 0;
            bool prime = false;

            for (int j = 5; j <= 1000; j++)
            {
                for (int i = 2; i < j; i++)
                {
                    rem = j % i;
                    if (rem == 0)
                    {
                        prime = true;
                        break;
                    }
                }
                if (prime != true)
                {
                    System.Console.Write("\t{0}", j);
                }
                prime = false;
            }
        }
    }
}
