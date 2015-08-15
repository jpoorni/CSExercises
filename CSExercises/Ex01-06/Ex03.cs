using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Enter a double precision number and find its square

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            double number  = 0;
            double square = 0;

            System.Console.Write("Enter a decimal number : ");
            number = Convert.ToDouble(System.Console.ReadLine());
            square = number * number;
            System.Console.WriteLine("The square of {0} is {1} " , number ,square);
        }
    }
}
