using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//input integer and find its square root

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int intNumber = 0;
            double dblSqrt = 0;

            System.Console.Write("Enter a integer number :");
            intNumber = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(intNumber);
            //sqrt funtion can take arguments only as double, here the input integer is converted to double
            dblSqrt = Math.Sqrt(Convert.ToDouble(intNumber)); 

            System.Console.WriteLine(dblSqrt);
        }
    }
}
