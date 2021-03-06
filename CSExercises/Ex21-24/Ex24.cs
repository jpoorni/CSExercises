using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            //int input = 15;

            System.Console.Write("Enter a number:");
            double input = System.Convert.ToDouble(System.Console.ReadLine()); 

            Random r = new Random();

            //using next -  returns no between 0 to n-1
            //double G = r.Next(1,input);

            //using next double -  returns no between 0 to 1
            double temp = r.NextDouble();
            Double G = temp * (input - 1);

            do 
            {
                G = ((G + (input / G))/2);
            }
            while (Math.Abs(input - (G * G)) < 0.00001);

            System.Console.WriteLine("Square root of {0} is {1:0#.00000}", input, G);
        }
    }
}