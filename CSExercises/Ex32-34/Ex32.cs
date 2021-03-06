using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            //int[] sales = new int[] {1000,2000,20,10,123,434,57,1,98,67,76,67800} ;
            //int[] sales = new int[] {5000, 12000, 20000};
            int[] sales = new int[12]; 

            for (int i = 0; i < 12; i++)
            {
                System.Console.Write("Enter sales for month {0} :",i);
                sales[i] = System.Convert.ToInt32(System.Console.ReadLine());
            }

            //Assumed maximum sales is month-0
            int max = sales[0];
            //Assumed minimum sales is month-0
            int min = sales[0];

            int maxmonth = 0, minmonth = 0, total = 0;
            double avgSales = 0;

            for (int i = 0 ; i<sales.Length;i++)
            {
                if (max < sales[i]) 
                { 
                    maxmonth = i;
                    max = sales[i];
                }
                if (min > sales[i])
                {
                    minmonth = i;
                    min = sales[i];
                }
            }

            //System.Console.WriteLine("Maximum sales :{0},{1}", maxmonth,sales[maxmonth]);
            //System.Console.WriteLine("Minimum sales :{0},{1}", minmonth, sales[minmonth]);

            System.Console.WriteLine("Maximum sales :{0}", maxmonth);
            System.Console.WriteLine("Minimum sales :{0}", minmonth);

            for (int i = 0 ; i<sales.Length;i++)
            {
                total = total + sales[i];
            }
            avgSales = total / sales.Length;  

            System.Console.WriteLine("Average sales :{0}", avgSales);
        }
    }
}
