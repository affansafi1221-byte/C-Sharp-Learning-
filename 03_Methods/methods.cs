using System;

namespace CSharpFundamentals._03_Methods

{
    internal class Methods
    {
        public static void Run()
        {
            DisplayName("Safii");
            DisplaySemester(6);
            DisplayCourse("Software Engineering");
            DisplayAge(20);

            double cgpa = CalculateCGPA(2.97, 3.20);
            Console.WriteLine("Average CGPA: " + cgpa);
        }

        static void DisplayName(string name)
        {
            Console.WriteLine("Student Name: " + name);
        }

        static void DisplaySemester(int semester)
        {
            Console.WriteLine("Current Semester: " + semester);
        }

        static void DisplayCourse(string course)
        {
            Console.WriteLine("Current Course: " + course);
        }

        static void DisplayAge(int age)
        {
            Console.WriteLine("Student Age: " + age);
        }

        static double CalculateCGPA(double cgpa1, double cgpa2)
        {
            return (cgpa1 + cgpa2) / 2;
        }
    }
}