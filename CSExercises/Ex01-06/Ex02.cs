using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Read a number and find its square

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            int number = 0;
            int square = 0;

            System.Console.Write("Enter a number :");
            number = Convert.ToInt16(System.Console.ReadLine());
            square = number * number;

            System.Console.WriteLine("Square of {0} is {1} ", number, square);

            
        }
    }
}
