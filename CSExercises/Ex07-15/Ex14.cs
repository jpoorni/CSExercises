using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//calculating area of a triangle
//area =    SQUAREROOT[s(s-a)(s-b)(s-c)] where s=(a+b+c)/2

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double dblSideA = 0, dblSideB = 0,dblSideC = 0;
            double dblS = 0, dblArea = 0, dblTemp = 0, dblTemp1 = 0, dblTemp2 = 0;

            System.Console.Write("Enter the length of Side A:");
            dblSideA = Convert.ToDouble(System.Console.ReadLine());

            System.Console.Write("Enter the length of Side B:");
            dblSideB = Convert.ToDouble(System.Console.ReadLine());

            System.Console.Write("Enter the length of Side C:");
            dblSideC = Convert.ToDouble(System.Console.ReadLine());

            //to check if the triangle can be formed or not
            // a + b > c ; b + c > a ; a + c > b
            //if all the above 3 rules cannot be satisfied, then a triangle cannot be formed

            if (((dblSideA + dblSideB) > dblSideC) && ((dblSideB + dblSideC) > dblSideA) && ((dblSideA + dblSideC) > dblSideB))
            {
                dblS = (dblSideA + dblSideB + dblSideC) / 2;
                dblTemp = dblS - dblSideA;
                dblTemp1 = dblS - dblSideB;
                dblTemp2 = dblS - dblSideC;

                dblArea = Math.Sqrt(dblS*dblTemp*dblTemp1*dblTemp2);
                System.Console.WriteLine("Area = {0}",dblArea);
            }
            else
            {
                System.Console.WriteLine("Triangle cannot be formed!");
            }
        }
    }
}