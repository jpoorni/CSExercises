namespace CSExercises
{
    public class Ex35B
    {
        public static void Main(string[] args)
        {
            //string s = "Poornima";
            string s;
            int countA = 0, countE = 0,countI = 0,countO = 0,countU = 0;

            System.Console.Write("Please enter a phrase :");
            s = System.Console.ReadLine();
            string temp = "";

                for (int i = 0; i < s.Length ; i++)
                {
                    temp = s.Substring(i, 1);

                    switch (temp.ToLower())
                    {
                        case "a" :
                            countA ++;
                            break;
                        case "e":
                            countE++;
                            break;
                        case "i":
                            countI++;
                            break;
                        case "o":
                            countO++;
                            break;
                        case "u":
                            countU++;
                            break;
                        default:
                            break;
                    }
                }
                System.Console.WriteLine("Number of a : {0}",countA);
                System.Console.WriteLine("Number of e : {0}",countE);
                System.Console.WriteLine("Number of i : {0}",countI);
                System.Console.WriteLine("Number of o : {0}",countO);
                System.Console.WriteLine("Number of u : {0}",countU);
            }
        }
    }

