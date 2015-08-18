using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

//taxi fare calculation

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double dblDistance = 0,dblTemp1 =0, dblTaxiFare =0;

            System.Console.Write("Enter the distance Travelled :");
            dblTemp1 = System.Convert.ToDouble(System.Console.ReadLine());

            if (dblTemp1 <= 0.5) 
            {
                dblTaxiFare = 2.40;
            }
            else if (dblTemp1 > 0.05 && dblTemp1 <= 8.5 )
            {
                double t = (dblTemp1 - 0.5) * 10;
                dblTaxiFare = 2.40 + (t * 0.04);
            }
            else
            {
                dblDistance = Math.Round(dblTemp1, 2);
            
            //System.Console.WriteLine("{0}", dblDistance);

                double temp = 0, temp1 = 0, temp2 = 0, temp3 = 0;

                temp = dblDistance * 100;
                temp1 = temp % 100; //finding the last two digits
                temp2 = temp1 % 10; //finding the last digit

                if (temp2 > 0)
                    temp3 = temp + (10 - temp2);
                else
                    temp3 = temp;

                double dblDistance1 = (temp3 / 100);
                //System.Console.WriteLine("Taxi Fare after rounding upwards = {0:c}", dblDistance1);

                temp3 = dblDistance1 * 10;
                //System.Console.WriteLine("{0}", temp3);

                dblTaxiFare = 2.40 + (85 * 0.04) + ((temp3 - 90) * 0.05);
          }

            System.Console.WriteLine("\tTaxi Fare = {0:c}", dblTaxiFare);
        }
    }
}