using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calculate Taxi Fare
//Minimum fixed charge : $2.40
//In addition the fare would be computed at 40 cents per kilometer
//print the fare rounded upwards

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double dblFixedCharge = 2.40, dblPerKilometerCharge = 0.4; //40 cents per kilometer
            double dblDistanceTravelled = 0, dblTaxiFare = 0, dblTemp = 0;

            System.Console.Write("Enter the distance travelled :");
            dblDistanceTravelled = Convert.ToDouble(System.Console.ReadLine());


            dblTemp = dblFixedCharge + (dblDistanceTravelled * dblPerKilometerCharge);
            double dblTemp1 = 0;
            dblTemp1 = Math.Round(dblTemp, 2);

            double temp = 0, temp1 = 0, temp2 = 0, temp3 = 0;
            temp = dblTemp1 * 100;
            temp1 = temp % 100; //finding the last two digits
            temp2 = temp1 % 10; //finding the last digit

            if (temp2 > 0)
                temp3 = temp + (10 - temp2);
            else
                temp3 = temp;

            dblTaxiFare = (temp3 / 100);
            System.Console.WriteLine("Taxi Fare after rounding upwards = {0:c}", dblTaxiFare);
        }
    }
}
