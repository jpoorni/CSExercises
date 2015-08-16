using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//amstrong nuber or not 
//confine the input to 3 digit examples only ie.,number values 100...999
//eg 153 = 1^3 + 5^3 + 3^3

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int intNumber = 0, intFirstDigit = 0, intSecondDigit = 0, intThirdDigit = 0, intTemp = 0;
            double dblAmstrong = 0;
            System.Console.Write("Enter a three digit number :");
            intNumber = Convert.ToInt16(System.Console.ReadLine());

            if ((intNumber < 100) || (intNumber > 999))
            {
                System.Console.WriteLine("Input a number between 100 - 999");
            }
            else
            {
                intFirstDigit = intNumber / 100;
                intTemp = intNumber % 100;
                intSecondDigit = intTemp / 10;
                intThirdDigit = intTemp % 10;

                dblAmstrong = Math.Pow(intFirstDigit, 3) + Math.Pow(intSecondDigit, 3) + Math.Pow(intThirdDigit, 3);

                //System.Console.WriteLine("{0},{1},{2}", intFirstDigit, intSecondDigit, intThirdDigit);
                //System.Console.WriteLine("{0}", dblAmstrong);

                if (dblAmstrong == intNumber)
                    System.Console.WriteLine("{0} is an Amstrong Number",intNumber);
                else
                    System.Console.WriteLine("{0} is not an Amstrong Number",intNumber);
            }
        }
    }
}