using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//converting centigrade to farenheit

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double dblCentigrade = 0 , dblFarenheit;

            System.Console.Write("Enter temperature in Centigrade scale :");
            dblCentigrade = Convert.ToDouble(System.Console.ReadLine());
            dblFarenheit = (1.8 * dblCentigrade) + 32;
            System.Console.WriteLine("\n{0} Centigrade  = {1} Farenheit " , dblCentigrade, dblFarenheit);
        }
    }
}
