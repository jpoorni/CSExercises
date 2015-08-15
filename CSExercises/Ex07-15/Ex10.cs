using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//calculate Distance = Square Root of [(x2-x1)^2 + (y2-y1)^2]

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            int intX1 = 0, intX2 = 0, intY1 = 0, intY2 = 0;
            double dblDistance = 0, dblTempX = 0, dblTempY = 0;

            System.Console.Write("Enter X1 :");
            intX1 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Enter Y1 :");
            intY1 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Enter X2 :");
            intX2 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Enter Y2 :");
            intY2 = Convert.ToInt32(System.Console.ReadLine());

            dblTempX = (intX2 - intX1) * (intX2 - intX1);
            dblTempY = (intY2 - intY1) * (intY2 - intY1);
            dblDistance = Math.Sqrt (dblTempX + dblTempY);

            System.Console.WriteLine("\t\tDistance = Square Root of [(x2-x1)^2 + (y2-y1)^2]");
            System.Console.WriteLine("\nDistance = {0:0#.00}",dblDistance);

        }
    }
}
