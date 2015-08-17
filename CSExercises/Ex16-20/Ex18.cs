using System.Text;
using System.Linq;
using System.Threading.Tasks;

//Grading system

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            int intMark = 0;
            string strGrade = "";

            System.Console.Write("Enter your marks :");
            intMark = System.Convert.ToInt32(System.Console.ReadLine());
            
            if (intMark < 0 || intMark >100)
            {
                strGrade = "**Error**";
            }
            else if (intMark >=80 && intMark <=100)
            {
                strGrade = "A";
            }
            else if (intMark >= 60 && intMark <= 79)
            {
                strGrade = "B";
            }
            else if (intMark >= 40 && intMark <= 59)
            {
                strGrade = "C";
            }
            else if (intMark <= 0 || intMark < 40)
            {
                strGrade = "F";
            }
            
            if (strGrade != "**Error**")
            {
                System.Console.WriteLine("You scored {0} marks which is {1} grade",intMark,strGrade);
            }
            else
            {
                System.Console.WriteLine("{0}", strGrade);
            }
        }
    }
}