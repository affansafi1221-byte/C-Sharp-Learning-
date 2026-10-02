using System;
using System.Collections.Generic;

namespace CSharpFundamentals._07_Modern
{
    internal class moderncsharp
    {
        public void Run()
        {
            Console.WriteLine("===== VAR =====");

            var name = "Safi";
            var age = 20;

            Console.WriteLine(name);
            Console.WriteLine(age);


            Console.WriteLine("\n===== NULLABLE REFERENCE TYPES =====");

            string? nullableName = null;

            Console.WriteLine(nullableName);


            Console.WriteLine("\n===== NULL COALESCING =====");

            string? city = null;

            string resultCity = city ?? "Karachi";

            Console.WriteLine(resultCity);


            Console.WriteLine("\n===== NULL CONDITIONAL =====");

            string? username = null;

            Console.WriteLine(username?.Length);


            Console.WriteLine("\n===== PATTERN MATCHING =====");

            object value = 25;

            if (value is int matchedNumber)
            {
                Console.WriteLine("Number: " + matchedNumber);
            }


            Console.WriteLine("\n===== SWITCH EXPRESSION =====");

            int marks = 85;

            string grade = marks switch
            {
                >= 80 => "A",
                >= 70 => "B",
                >= 60 => "C",
                >= 50 => "D",
                _ => "F"
            };

            Console.WriteLine(grade);


            Console.WriteLine("\n===== TUPLE =====");

            (string Name, int Age) person = ("Safi", 20);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);


            Console.WriteLine("\n===== TUPLE RETURN =====");

            var student = GetStudent();

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);


            Console.WriteLine("\n===== RECORD =====");

            StudentRecord studentRecord =
                new StudentRecord("Safi", 20);

            Console.WriteLine(studentRecord.Name);
            Console.WriteLine(studentRecord.Age);


            Console.WriteLine("\n===== RECORD WITH =====");

            StudentRecord updatedStudent = studentRecord with
            {
                Age = 21
            };

            Console.WriteLine(updatedStudent.Name);
            Console.WriteLine(updatedStudent.Age);


            Console.WriteLine("\n===== EXPRESSION-BODIED MEMBER =====");

            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(10, 20));
            Console.WriteLine(calculator.Square(5));


            Console.WriteLine("\n===== ARRAY =====");

            int[] numbers = new int[]
            {
                10,
                20,
                30,
                40
            };

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n===== LIST =====");

            List<string> names = new List<string>
            {
                "Safi",
                "Ali",
                "Ahmed"
            };

            foreach (string nameItem in names)
            {
                Console.WriteLine(nameItem);
            }


            Console.WriteLine("\n===== TARGET-TYPED NEW =====");

            List<int> marksList = new List<int>();

            marksList.Add(80);
            marksList.Add(90);
            marksList.Add(85);

            foreach (int markItem in marksList)
            {
                Console.WriteLine(markItem);
            }


            Console.WriteLine("\n===== PATTERN MATCHING WITH SWITCH =====");

            object data = "Hello";

            string message = data switch
            {
                int integerValue => "Integer: " + integerValue,
                string textValue => "String: " + textValue,
                double doubleValue => "Double: " + doubleValue,
                _ => "Unknown type"
            };

            Console.WriteLine(message);


            Console.WriteLine("\n===== PROPERTY PATTERN =====");

            Person personData = new Person("Safi", 20);

            if (personData is { Age: >= 18 })
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }


            Console.WriteLine("\n===== RELATIONAL PATTERN =====");

            int temperature = 35;

            string weather = temperature switch
            {
                >= 40 => "Very Hot",
                >= 30 => "Hot",
                >= 20 => "Normal",
                _ => "Cold"
            };

            Console.WriteLine(weather);
        }

        private static (string Name, int Age) GetStudent()
        {
            return ("Safi", 20);
        }
    }

    internal record StudentRecord(string Name, int Age);

    internal class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Square(int value)
        {
            return value * value;
        }
    }

    internal class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}