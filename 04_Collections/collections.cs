using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    internal class Collections
    {
        public static void Run()
        {
            Console.WriteLine("===== STUDENT COURSE MANAGEMENT =====\n");

            // 1. ARRAY
            string[] courses =
            {
                "Software Engineering",
                "Operating Systems",
                "Computer Networks",
                "Multivariate Calculus",
                "Software Project Management"
            };

            Console.WriteLine("--- Courses ---");

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + courses[i]);
            }

            // 2. LIST
            List<string> skills = new List<string>
            {
                "C#",
                "SQL",
                "Git",
                "ASP.NET Core"
            };

            skills.Add("Entity Framework Core");

            Console.WriteLine("\n--- Skills ---");

            foreach (string skill in skills)
            {
                Console.WriteLine(skill);
            }

            // 3. DICTIONARY
            Dictionary<string, int> courseCredits = new Dictionary<string, int>
            {
                { "Software Engineering", 3 },
                { "Operating Systems", 3 },
                { "Computer Networks", 3 },
                { "Multivariate Calculus", 3 }
            };

            Console.WriteLine("\n--- Course Credit Hours ---");

            foreach (var course in courseCredits)
            {
                Console.WriteLine(course.Key + ": " + course.Value + " credit hours");
            }

            // 4. HASHSET
            HashSet<string> technologies = new HashSet<string>
            {
                "C#",
                "SQL",
                "C#",
                "ASP.NET Core",
                "SQL"
            };

            Console.WriteLine("\n--- Technologies (Unique) ---");

            foreach (string technology in technologies)
            {
                Console.WriteLine(technology);
            }

            Console.WriteLine("\n===== COLLECTIONS COMPLETED =====");
        }
    }
}