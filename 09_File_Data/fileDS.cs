using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace CSharpFundamentals._09_File_Data
{
    internal class FileData
    {
        public void Run()
        {
            Console.WriteLine("File and Data Practice");

            Console.WriteLine("\n1. File Exists");

            string fileName = "notes.txt";

            Console.WriteLine(File.Exists(fileName));


            Console.WriteLine("\n2. Write File");

            File.WriteAllText(fileName, "Today I practiced C# file handling.");

            Console.WriteLine("File created");


            Console.WriteLine("\n3. Read File");

            string text = File.ReadAllText(fileName);

            Console.WriteLine(text);


            Console.WriteLine("\n4. Add More Text");

            File.AppendAllText(fileName, "\nI am learning .NET backend.");

            Console.WriteLine(File.ReadAllText(fileName));


            Console.WriteLine("\n5. Read Lines");

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }


            Console.WriteLine("\n6. FileInfo");

            FileInfo fileInfo = new FileInfo(fileName);

            Console.WriteLine("Name: " + fileInfo.Name);
            Console.WriteLine("Size: " + fileInfo.Length);


            Console.WriteLine("\n7. Directory");

            string folderName = "PracticeFiles";

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            Console.WriteLine("Folder ready");


            Console.WriteLine("\n8. Create File Inside Folder");

            string secondFile = Path.Combine(folderName, "student.txt");

            File.WriteAllText(secondFile, "Name: Safi\nAge: 20");

            Console.WriteLine(File.ReadAllText(secondFile));


            Console.WriteLine("\n9. StreamWriter");

            using (StreamWriter writer = new StreamWriter("log.txt"))
            {
                writer.WriteLine("Started learning file handling");
                writer.WriteLine("Practicing StreamWriter");
            }

            Console.WriteLine(File.ReadAllText("log.txt"));


            Console.WriteLine("\n10. StreamReader");

            using (StreamReader reader = new StreamReader("log.txt"))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }


            Console.WriteLine("\n11. JSON");

            Student student = new Student
            {
                Name = "Safi",
                Age = 20,
                City = "Karachi"
            };

            string json = JsonSerializer.Serialize(student);

            Console.WriteLine(json);


            Console.WriteLine("\n12. Save JSON");

            File.WriteAllText("student.json", json);

            Console.WriteLine("JSON saved");


            Console.WriteLine("\n13. Read JSON");

            string savedJson = File.ReadAllText("student.json");

            Student? loadedStudent =
                JsonSerializer.Deserialize<Student>(savedJson);

            if (loadedStudent != null)
            {
                Console.WriteLine(loadedStudent.Name);
                Console.WriteLine(loadedStudent.Age);
                Console.WriteLine(loadedStudent.City);
            }


            Console.WriteLine("\n14. Delete Test Files");

            File.Delete(fileName);
            File.Delete(secondFile);
            File.Delete("log.txt");
            File.Delete("student.json");

            if (Directory.Exists(folderName))
            {
                Directory.Delete(folderName);
            }

            Console.WriteLine("Practice files deleted");
        }
    }

    internal class Student
    {
        public string Name { get; set; } = "";

        public int Age { get; set; }

        public string City { get; set; } = "";
    }
}