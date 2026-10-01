using System;

namespace CSharpFundamentals   // was: Basics
{
    internal class Controlflow                     // was: Variable
    {
        public static void Run()           // was: static void Main()
        {
            Console.Write("Admission Eligibility Check\n");
            Console.ReadLine();
            Console.Write("Enter your intermediate percentage: ");
            double percentage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Intermediate Completion year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (percentage >= 60 && year >= 2020 && year <= 2024)
            {
                Console.WriteLine("You are eligible for admission.");
            }
            else
            {
                Console.WriteLine("You are not eligible for admission.");
            }
        }
    }
}