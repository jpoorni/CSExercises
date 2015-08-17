using System.Text;
using System.Linq;
using System.Threading.Tasks;

//Good morning <salutation><name> 
//age  >=45 & male then  uncle <name>
//age  < 45 & male then Mr. <name>
//age  >=45 & female then  Aunty <name>
//age  < 45 & male then Ms. <name>


namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string strName = "";
            string strGender = "";
            int intAge = 0;

            System.Console.Write("Enter your name :");
            strName = System.Console.ReadLine();
            System.Console.Write("Enter gender :(F = Female , M = Male)");
            strGender = System.Console.ReadLine();
            System.Console.Write("Enter age :");
            intAge = System.Convert.ToInt32(System.Console.ReadLine());


           if ((strGender == "M") && (intAge >=45))
           {
               System.Console.WriteLine("Good Morning Uncle {0}",strName);
           }
           else if ((strGender == "M") && (intAge < 45))
           {
               System.Console.WriteLine("Good Morning Mr. {0}", strName);
           }
           else if ((strGender == "F") && (intAge >=45))
           {
               System.Console.WriteLine("Good Morning Aunty {0}", strName);
           }
           else if ((strGender == "F") && (intAge < 45))
           {
               System.Console.WriteLine("Good Morning Ms. {0}", strName);
           }
           else
           {
               System.Console.WriteLine("Incorrect Input");
           }
        }
    }
}