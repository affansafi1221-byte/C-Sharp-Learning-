using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CSharpFundamentals.Basics
{
    class Variable
    {
        public static void Run()
        {
            Console.Write("Enter your Name ");
            string name = Console.ReadLine();
            

            Console.Write("Your Current Semester :");
            int Semester = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Your Current CGPA : ");
            float CGPA = Convert.ToSingle(Console.ReadLine());
           

            Console.Write("Your Current Age : ");
            byte Age = Convert.ToByte(Console.ReadLine());

            Console.Write("Hello, " + name + "! Welcome to C# Fundamentals." ?? "");
            Console.WriteLine("Your Current Semester is : " + Semester);
            Console.WriteLine("Your Current CGPA is: " + CGPA);
            Console.WriteLine("Your Current Age is: " + Age);
        }
    }
}