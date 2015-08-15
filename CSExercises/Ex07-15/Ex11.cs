using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calculate Taxi Fare
//Minimum fixed charge : $2.40
//In addition the fare would be computed at 40 cents per kilometer
//print the fare without any number formating

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double dblFixedCharge = 2.40, dblPerKilometerCharge = 0.4; //40 cents per kilometer
            double dblDistanceTravelled = 0, dblTaxiFare = 0;

            System.Console.Write("Enter the distance travelled :");
            dblDistanceTravelled = Convert.ToDouble(System.Console.ReadLine());

            dblTaxiFare = dblFixedCharge + (dblDistanceTravelled * dblPerKilometerCharge);
            System.Console.WriteLine("Taxi Fare = {0}",dblTaxiFare);
        }
    }
}
