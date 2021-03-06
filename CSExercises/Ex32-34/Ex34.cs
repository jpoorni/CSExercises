using System;

//students & marks
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            double[,] marks = new double[,] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 } , {99,9,18,17},{62,3,65,75},
                                            {40,96,53,23}, {81,15,27,30},{21,70,100,22}, {88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72} };

            double total, totalStudents = 0, totalSubjects = 0  ;
            double classAverage = 0, classTotal = 0, subjectTotal = 0;

            totalStudents = marks.GetLength(0);
            totalSubjects = marks.GetLength(1);

            System.Console.WriteLine("Total marks obtained");
            System.Console.WriteLine("-------------------------");
            for (int i = 0 ;i < totalStudents;i++) //for each student
            {
                total = 0;
                for (int j = 0;j < totalSubjects;j++) //for each subject
                {
                    total = total + marks[i, j];
                }
                classTotal = classTotal + total;
                
                System.Console.WriteLine("student[{0}] = {1}", i, total);
                //System.Console.WriteLine("Total marks obtained by student-{0} is {1}",i,total);
            }

            //class average = class total / (no of students * no of subjects)
            classAverage = Math.Round((classTotal * 1.0) / (totalStudents * totalSubjects), 2);
            System.Console.WriteLine();

            System.Console.WriteLine("Total marks obtained by all students in subjects");
            double[] subAvg = new double[4]; 
            for (int i = 0; i < totalSubjects; i++) //for each subject
            {
                subjectTotal = 0;
                for (int j = 0; j < totalStudents; j++) //for each student
                {
                    subjectTotal = subjectTotal + marks[j, i];
                }
                subAvg[i] = subjectTotal / totalStudents;

                System.Console.WriteLine("subject({0}) is {1}", i, subjectTotal);
                //System.Console.WriteLine("Total marks obtained by all students in subject - {0} is {1}", i, subjectTotal);
                //System.Console.WriteLine("subject average - {0} is {1}", i, subAvg[i]);
            }
            System.Console.WriteLine("\nClass Average for all subjects:{0}\n", classAverage);

            double variance = 0, standardDeviation = 0 ;
            //Standard deviation is square root of variance
            //variance = {[SUM OF (Xi - M)^2)]/N }; i = 1 to N
            //N is number of data Elements (Xi) and 
            //M is mean(average).
            System.Console.WriteLine("StandardDeviation of subjects");
            for (int i = 0; i < totalSubjects; i++) //for each subject
            {
                double temp2 = 0; 
                for (int j = 0; j < totalStudents; j++) //for each student
                {
                    temp2 = temp2 + Math.Pow((marks[j,i] - subAvg[i]),2);
                }
                //System.Console.WriteLine("variance of subject {0} = {1}", i, temp2/totalStudents);
                variance = temp2 / totalStudents ;
                standardDeviation = Math.Sqrt(variance);
                //System.Console.WriteLine("subject - average & variance & SD : {0} - {1} & {2} & {3}", i, subAvg[i], variance,standardDeviation);
                //System.Console.WriteLine("SD of subject({0}) = {1:0##.000}", i, standardDeviation);

                System.Console.WriteLine("subject({0}) = {1:0##.000}", i, standardDeviation);
            }
            
            
            
        }
    }
}
