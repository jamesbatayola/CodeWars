using System;
using System.Linq;

namespace StudentGradeAveragingSystem
{
    class StudentGrades
    {
        static void Main(string[] args)
        {
            int numOfStudents;
            float sumOfGrades = 0;
            float averageGrade;

            // Handles non numeric values
            while (true)
            {
                Console.WriteLine("Enter the number of students:");
                string? temp = Console.ReadLine();

                if(temp.All(char.IsDigit))
                {
                    numOfStudents = Convert.ToInt32(temp);
                    break;
                } 
                else
                    Console.WriteLine("\nInvalid input, please enter a digit");
            }
           
            // Loop to collect student grades
            for (int i = 0; i < numOfStudents; i++) // Fixed #1: removed equal operator
            {
                Console.WriteLine("Enter grade for student #" + (i + 1) + ":");
                float studentGrade = float.Parse(Console.ReadLine());

                if (studentGrade < 0 || studentGrade > 100) // Fixed #2: Incorrect range check
                {
                    Console.WriteLine("\nInvalid grade, please enter a value between 0 and 100.");
                    i--; // to makes the loop stay
                    continue; // Fixed #3: Replaced 'break' with 'continue'
                }

                sumOfGrades += studentGrade;
            }

            averageGrade = sumOfGrades / numOfStudents; // Error #4: Division by zero

            Console.WriteLine("The average grade is: " + averageGrade);

            Console.ReadLine();
        }
    }
}