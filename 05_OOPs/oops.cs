using System;

internal class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }

    public Student()
    {
        Name = "Unknown";
        Age = 0;
        GPA = 0;
    }

    public Student(string name, int age, double gpa)
    {
        Name = name;
        Age = age;
        GPA = gpa;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("GPA: " + GPA);
    }

    public void Study()
    {
        Console.WriteLine(Name + " is studying.");
    }
}

internal class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        Console.WriteLine("My name is " + Name);
    }
}

internal class Employee : Person
{
    public double Salary { get; set; }

    public void Work()
    {
        Console.WriteLine(Name + " is working.");
    }
}

internal class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

internal class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

internal class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

internal class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

internal abstract class Shape
{
    public abstract double GetArea();
}

internal class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

internal interface IPayment
{
    void Pay(double amount);
}

internal class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid Rs. " + amount + " using cash.");
    }
}

internal class BankPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid Rs. " + amount + " using bank.");
    }
}

internal class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
    }
}

internal class OOPs
{
    public void Run()
    {
        Console.WriteLine("-- CLASS AND OBJECT --");

        Student student = new Student("Safi", 20, 3.2);
        student.DisplayInfo();
        student.Study();

        Console.WriteLine("\n-- INHERITANCE --");

        Employee employee = new Employee();
        employee.Name = "Ali";
        employee.Salary = 50000;

        employee.Introduce();
        employee.Work();

        Console.WriteLine("Salary: " + employee.Salary);

        Console.WriteLine("\n-- ENCAPSULATION --");

        BankAccount account = new BankAccount();
        account.Deposit(50000);
        account.Withdraw(10000);

        Console.WriteLine("Balance: " + account.Balance);

        Console.WriteLine("\n-- METHOD OVERLOADING --");

        Calculator calculator = new Calculator();

        Console.WriteLine(calculator.Add(10, 20));
        Console.WriteLine(calculator.Add(10.5, 20.5));
        Console.WriteLine(calculator.Add(10, 20, 30));

        Console.WriteLine("\n- POLYMORPHISM -");

        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        animal1.MakeSound();
        animal2.MakeSound();

        Console.WriteLine("\n= ABSTRACTION =");

        Shape circle = new Circle(5);

        Console.WriteLine("Circle Area: " + circle.GetArea());

        Console.WriteLine("\n-- INTERFACE-- ");

        IPayment payment1 = new CashPayment();
        IPayment payment2 = new BankPayment();

        payment1.Pay(5000);
        payment2.Pay(10000);
    }
}