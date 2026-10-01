using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Basics
{
    internal class Datatype
    {
        public static void Run()
        {
            // Declare variables of different data types
            string courseName = "Software Engineering";
            int creditHours = 3;
            double courseFee = 12500.50;
            float passingPercentage = 50.0f;
            char grade = 'B';
            bool isPassed = true;
            decimal semesterFee = 45000.00m;

            Console.WriteLine("Course: " + courseName);
            Console.WriteLine("Credit Hours: " + creditHours);
            Console.WriteLine("Course Fee: " + courseFee);
            Console.WriteLine("Passing Percentage: " + passingPercentage);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Passed: " + isPassed);
            Console.WriteLine("Semester Fee: " + semesterFee);
        }
    }
}
