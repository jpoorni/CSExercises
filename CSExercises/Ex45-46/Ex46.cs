using System;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] newarr = new int[50];
            int[] count = new int[10] {0,0,0,0,0,0,0,0,0,0};

            Random r = new Random();
            

            for (int i=0;i<50;i++)
            {
                newarr[i] = r.Next(0, 10);
            }

            for (int i=0;i<newarr.Length;i++)
            {
                System.Console.Write("\t" + newarr[i]);

                switch (newarr[i])
                {
                case 0 :
                        count[0] = count[0] + 1;
                        break;
                case 1 :
                        count[1] = count[1] + 1;
                        break;
                case 2 :
                        count[2] = count[2] + 1;
                        break;
                case 3 :
                        count[3] = count[3] + 1;
                        break;
                case 4 :
                        count[4] = count[4] + 1;
                        break;
                case 5 :
                        count[5] = count[5] + 1;
                        break;
                case 6:
                        count[6] = count[6] + 1;
                        break;
                case 7:
                        count[7] = count[7] + 1;
                        break;
                case 8:
                        count[8] = count[8] + 1;
                        break;
                case 9:
                        count[9] = count[9] + 1;
                        break;
                default :
                        break;
                }
            }

            System.Console.WriteLine("\n\n");
            System.Console.WriteLine("Number\t      Count\t\t\t\tNumber");
            System.Console.WriteLine("--------------------                     -----------------------");

            for (int j = 0; j < count.Length; j++)
            {
                
                string temp = "", temp1="";

                //second way of printing *********
                if (count[j] > 0) 
                {
                    
                     temp1 = temp.PadLeft(count[j], '*');
                }
                System.Console.WriteLine("{0}\t\t{1}\t\t\t    {2}\t\t{3}",j,count[j],j,temp1);
            }

            //one way of printing *******

            ////System.Console.WriteLine("Number\t      Count");
            ////System.Console.WriteLine("--------------------");
            ////for (int j = 0; j < count.Length; j++)
            ////{
            ////    for (int i = 1; i <= count[j]; i++)
            ////    {
            ////        System.Console.Write("*");
            ////    }
            ////    System.Console.WriteLine();
            ////    //System.Console.WriteLine("{0}\t\t{1}", j, count[j]);
            ////}

        }
    }
}
