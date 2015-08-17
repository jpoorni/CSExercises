using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int QtyOfTv = 0, QtyOfDvd = 0, QtyOfMp3 = 0;
            double dblDis = 1, temp = 0, dblTotal = 0;

            System.Console.Write("Enter quantity for TV :");
            QtyOfTv = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter quantity for DVD :");
            QtyOfDvd = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter quantity for MP3 :");
            QtyOfMp3 = Convert.ToInt32(System.Console.ReadLine());

            temp = (QtyOfTv * 900) + (QtyOfDvd * 500) + (QtyOfMp3 * 700);
            //System.Console.WriteLine("total to chk for discount {0:c}", temp);

            if (temp > 5000) 
            {
                dblDis = 0.1;
            }
            else
            {
                dblDis = 0.15;
            }

            dblTotal = ((QtyOfTv * 900) * dblDis) + ((QtyOfDvd * 500) * dblDis) + (QtyOfMp3 * 700);

            System.Console.WriteLine("Total Price for this order is {0:c}", dblTotal);
        }
    }
}