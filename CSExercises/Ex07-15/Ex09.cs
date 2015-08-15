using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//input x & calculate y = 2x^2 -4x + 3

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            double dblX = 0, dblY=0, dblTemp;

            System.Console.Write("Enter X value:");
            dblX = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("\n\t\t\tY = 2X^2 - 4X + 3 ");
            
            dblTemp = (dblX * dblX);  
            dblY = ((2*dblTemp) - (4 * dblX) + 3);
            System.Console.WriteLine("The value of X = {0}", dblX);
            System.Console.WriteLine("The value of Y = {0}", dblY);
        }
    }
}
