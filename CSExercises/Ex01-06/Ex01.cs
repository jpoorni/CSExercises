using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Read a name and print the greeting

namespace CSExercises
{
    public class Ex01
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter your name :");
            string name;
            name = System.Console.ReadLine();
            System.Console.WriteLine("Good Morning {0}",name);
        }
    }
}
