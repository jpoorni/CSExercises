namespace CSExercises
{
    public class Ex43
   {
        public static string Hex(int i)
        {

            string ans = "";
            int temp;
            int decimalNo = i;
            temp = decimalNo;

            ans = "";

            while (decimalNo > 0)
            {
                string s1;

                int remainder = decimalNo % 16;
                decimalNo = decimalNo / 16;
                switch (remainder)
                {
                    case 10:
                        s1 = "A";
                        break;
                    case 11:
                        s1 = "B";
                        break;
                    case 12:
                        s1 = "C";
                        break;
                    case 13:
                        s1 = "D";
                        break;
                    case 14:
                        s1 = "E";
                        break;
                    case 15:
                        s1 = "F";
                        break;
                    default:
                        s1 = System.Convert.ToString(remainder);
                        break;
                }
                ans = ans + s1;
            }
            
            return ans;
        }
    

    public static void Main(string[] args)
    {
        //int decimalNo = 188;
        string output = "";

        System.Console.WriteLine("Decimal No \tHexadecimal No");
        System.Console.WriteLine("-----------      ------------");

        for (int j = 1; j <= 100; j++)
        {
            output = Hex(j);
            string ans1 = "";

            for (int i = 0; i < output.Length; i++)
            {
                ans1 = ans1 + output.Substring((output.Length - 1) - i, 1);
            }
            System.Console.WriteLine(j + "\t\t\t" + ans1 + "\t");
        }
    }
  }
}
