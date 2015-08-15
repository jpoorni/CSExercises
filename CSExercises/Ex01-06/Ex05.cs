using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            double dblnumber = 0;
            double dblsquareroot = 0;

            System.Console.Write("Enter a decimal number : ");
            dblnumber = Convert.ToDouble(System.Console.ReadLine());
            dblsquareroot = Math.Sqrt(dblnumber);
            System.Console.WriteLine("The square of {0} = {1:#0.000} ", dblnumber, dblsquareroot);
        }
    }
}
