using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

//Good morning {Mr/Ms} {name}

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string strName = "";
            string strGender = "";

            System.Console.Write("Enter your name :");
            strName = System.Console.ReadLine();
            System.Console.Write("Enter gender :(F = Female , M = Male)");
            strGender = System.Console.ReadLine();

           if (strGender == "M")
           {
               System.Console.WriteLine("Good Morning Mr. {0}",strName);
           }
           else
           {
               System.Console.WriteLine("Good Morning Ms. {0}", strName);
           }
        }
    }
}