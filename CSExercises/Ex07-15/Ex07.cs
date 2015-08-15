using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//input salary - calculate Housing Allowance, Transport Allowance - print totalincome

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double dblSalary = 0 ;
            double dblHousingAllowance = 0, dblTransportAllowance = 0 , dblTotalIncome = 0;

            System.Console.Write("Enter the Salary :");
            dblSalary = Convert.ToDouble(System.Console.ReadLine());

            dblHousingAllowance = dblSalary * 0.1; //10% of salary
            dblTransportAllowance = dblSalary * 0.03;//3% of salary
            dblTotalIncome = dblSalary + dblHousingAllowance + dblTransportAllowance;

            System.Console.WriteLine("\nTotal Income = {0:C}" ,dblTotalIncome);
        }
    }
}
