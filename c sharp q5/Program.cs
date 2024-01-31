using System;
namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter student name: ");
            string name = Console.ReadLine();

            Console.Write("enter exam marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            string grade;

            if (marks >= 75)
            {
                grade = "A";
            }
            else if (marks >= 60)
            {
                grade = "B";
            }
            else if (marks >= 50)
            {
                grade = "C";
            }
            else if (marks >= 40)
            {
                grade = "D";
            }
            else 
            {
                grade = "Failed";
            }
            Console.WriteLine("Grade for {0}: {1}:", name,grade);
        }
    }
}
