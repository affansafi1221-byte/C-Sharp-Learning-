using System;
using System.Collections.Generic;
using System.Linq;

internal class Operations
{
    public void Run()
    {
        // Array
        Console.WriteLine("===== ARRAY =====");

        int[] marks = { 70, 85, 60, 90, 75 };

        Console.WriteLine(marks[0]);

        marks[0] = 80;

        Console.WriteLine(marks.Length);

        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }


        // List
        Console.WriteLine("\n===== LIST =====");

        List<string> students = new List<string>();

        students.Add("Ali");
        students.Add("Ahmed");
        students.Add("Safi");

        students.AddRange(new List<string> { "Hamza", "Usman" });

        Console.WriteLine(students[0]);

        students[0] = "Ayan";

        students.Insert(1, "Bilal");

        students.Remove("Ahmed");

        students.RemoveAt(0);

        Console.WriteLine(students.Contains("Safi"));

        Console.WriteLine(students.Count);

        students.Sort();

        students.Reverse();

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }


        // Dictionary
        Console.WriteLine("\n===== DICTIONARY =====");

        Dictionary<int, string> studentNames = new Dictionary<int, string>();

        studentNames.Add(101, "Ali");
        studentNames.Add(102, "Ahmed");
        studentNames.Add(103, "Safi");

        Console.WriteLine(studentNames[101]);

        studentNames[101] = "Ayan";

        Console.WriteLine(studentNames.ContainsKey(102));

        Console.WriteLine(studentNames.ContainsValue("Safi"));

        studentNames.Remove(103);

        Console.WriteLine(studentNames.Count);

        foreach (var student in studentNames)
        {
            Console.WriteLine(student.Key + " " + student.Value);
        }


        // HashSet
        Console.WriteLine("\n===== HASHSET =====");

        HashSet<int> numbers = new HashSet<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(20);

        Console.WriteLine(numbers.Contains(20));

        numbers.Remove(30);

        Console.WriteLine(numbers.Count);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> setB = new HashSet<int> { 3, 4, 5, 6 };

        HashSet<int> union = new HashSet<int>(setA);
        union.UnionWith(setB);

        foreach (int number in union)
        {
            Console.WriteLine(number);
        }

        HashSet<int> intersection = new HashSet<int>(setA);
        intersection.IntersectWith(setB);

        foreach (int number in intersection)
        {
            Console.WriteLine(number);
        }

        HashSet<int> difference = new HashSet<int>(setA);
        difference.ExceptWith(setB);

        foreach (int number in difference)
        {
            Console.WriteLine(number);
        }


        // Queue
        Console.WriteLine("\n===== QUEUE =====");

        Queue<string> customers = new Queue<string>();

        customers.Enqueue("Ali");
        customers.Enqueue("Ahmed");
        customers.Enqueue("Safi");

        Console.WriteLine(customers.Peek());

        Console.WriteLine(customers.Dequeue());

        Console.WriteLine(customers.Contains("Ahmed"));

        Console.WriteLine(customers.Count);

        foreach (string customer in customers)
        {
            Console.WriteLine(customer);
        }


        // Stack
        Console.WriteLine("\n===== STACK =====");

        Stack<string> pages = new Stack<string>();

        pages.Push("Google");
        pages.Push("YouTube");
        pages.Push("GitHub");

        Console.WriteLine(pages.Peek());

        Console.WriteLine(pages.Pop());

        Console.WriteLine(pages.Contains("Google"));

        Console.WriteLine(pages.Count);

        foreach (string page in pages)
        {
            Console.WriteLine(page);
        }


        // LINQ
        Console.WriteLine("\n===== LINQ =====");

        List<int> scores = new List<int>
        {
            45, 60, 72, 85, 90, 55
        };

        var passingScores = scores.Where(score => score >= 60);

        foreach (int score in passingScores)
        {
            Console.WriteLine(score);
        }

        var doubledScores = scores.Select(score => score * 2);

        foreach (int score in doubledScores)
        {
            Console.WriteLine(score);
        }

        var sortedScores = scores.OrderBy(score => score);

        foreach (int score in sortedScores)
        {
            Console.WriteLine(score);
        }

        Console.WriteLine(scores.First());

        Console.WriteLine(
            scores.FirstOrDefault(score => score > 95)
        );

        Console.WriteLine(
            scores.Any(score => score > 80)
        );

        Console.WriteLine(
            scores.All(score => score > 40)
        );

        Console.WriteLine(scores.Count);
    }
}