using System;
//descending order of marks

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] {63,29,75,82,55};

            

            for (int i = 0 ;i <marks.Length;i++)
            {
                string tempname ="";
                int tempmark = 0;

                for (int j=i+1;j<marks.Length;j++)
                {
                    if (marks[i] < marks[j])
                    {
                        tempmark = marks[i];
                        marks[i] = marks[j];
                        marks[j] = tempmark;

                        tempname = name[i];
                        name[i] = name[j];
                        name[j] = tempname;
                    }
                }
            }

            System.Console.WriteLine("Descending order of marks");
            System.Console.WriteLine("Name\t\tMark");
            System.Console.WriteLine("_______________________");
            for (int i = 0 ;i <marks.Length;i++)
            {
                System.Console.WriteLine("{0}\t\t{1}", name[i], marks[i]);
            }

            //Alphabetical order of students
            System.Console.WriteLine("\n\nAlphabetical order of students");
            for (int i =0 ;i<name.Length;i++)
            {
                string tempname = "";
                int tempmark = 0;

                for (int j = i + 1; j < name.Length; j++)
                {
                    if (name[i].CompareTo(name[j]) == 1)
                    {
                        tempmark = marks[i];
                        marks[i] = marks[j];
                        marks[j] = tempmark;

                        tempname = name[i];
                        name[i] = name[j];
                        name[j] = tempname;
                    }
                }
            }

            System.Console.WriteLine("Name\t\tMark");
            System.Console.WriteLine("_______________________");
            for (int i = 0; i < marks.Length; i++)
            {
                System.Console.WriteLine("{0}\t\t{1}", name[i], marks[i]);
            }
        }
    }
}
