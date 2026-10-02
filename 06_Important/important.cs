using System;
using System.IO;

internal class Important
{
    private static int counter = 0;

    private const double TaxRate = 0.15;

    private readonly int accountNumber;

    public Important(int accountNumber)
    {
        this.accountNumber = accountNumber;
    }

    public void Run()
    {
        Console.WriteLine("===== STATIC =====");

        counter++;
        counter++;

        Console.WriteLine(counter);

        Console.WriteLine("\n===== CONST =====");

        double price = 1000;
        double tax = price * TaxRate;

        Console.WriteLine(tax);

        Console.WriteLine("\n===== READONLY =====");

        Console.WriteLine(accountNumber);

        Console.WriteLine("\n===== REF =====");

        int number = 10;

        ChangeValue(ref number);

        Console.WriteLine(number);

        Console.WriteLine("\n===== OUT =====");

        int result;

        GetResult(10, 20, out result);

        Console.WriteLine(result);

        Console.WriteLine("\n===== IN =====");

        int value = 50;

        ShowValue(in value);

        Console.WriteLine("\n===== PARAMS =====");

        int total = AddNumbers(10, 20, 30, 40);

        Console.WriteLine(total);

        Console.WriteLine("\n===== ENUM =====");

        OrderStatus status = OrderStatus.Shipped;

        Console.WriteLine(status);

        Console.WriteLine("\n===== STRUCT =====");

        student studentData = new student("Safi", 20);

        Console.WriteLine(studentData.Name);
        Console.WriteLine(studentData.Age);

        Console.WriteLine("\n===== DATETIME =====");

        DateTime currentDateTime = DateTime.Now;

        Console.WriteLine(currentDateTime);

        Console.WriteLine("\n===== DATEONLY =====");

        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

        Console.WriteLine(currentDate);

        Console.WriteLine("\n===== TIMEONLY =====");

        TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);

        Console.WriteLine(currentTime);

        Console.WriteLine("\n===== GUID =====");

        Guid userId = Guid.NewGuid();

        Console.WriteLine(userId);

        Console.WriteLine("\n===== NULLABLE =====");

        int? age = null;

        Console.WriteLine(age ?? 0);

        Console.WriteLine("\n===== VAR VS EXPLICIT =====");

        string name = "Safi";
        var city = "Karachi";

        Console.WriteLine(name);
        Console.WriteLine(city);

        Console.WriteLine("\n===== ACCESS MODIFIERS =====");

        AccessExample example = new AccessExample();

        example.PublicMethod();

        Console.WriteLine("\n===== USING =====");

        string path = "test.txt";

        File.WriteAllText(path, "Hello C#");

        string data = File.ReadAllText(path);

        Console.WriteLine(data);

        File.Delete(path);

        Console.WriteLine("\n===== IDISPOSABLE =====");

        using (Resource resource = new Resource())
        {
            resource.Use();
        }
    }

    private static void ChangeValue(ref int number)
    {
        number = 100;
    }

    private static void GetResult(int a, int b, out int result)
    {
        result = a + b;
    }

    private static void ShowValue(in int value)
    {
        Console.WriteLine(value);
    }

    private static int AddNumbers(params int[] numbers)
    {
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }

        return total;
    }
}

internal enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered
}

internal struct student
{
    public string Name;
    public int Age;

    public student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

internal class AccessExample
{
    private int privateValue = 10;
    protected int protectedValue = 20;
    internal int internalValue = 30;
    public int publicValue = 40;

    public void PublicMethod()
    {
        Console.WriteLine(privateValue);
        Console.WriteLine(protectedValue);
        Console.WriteLine(internalValue);
        Console.WriteLine(publicValue);
    }
}

internal class Resource : IDisposable
{
    public void Use()
    {
        Console.WriteLine("Resource is being used.");
    }

    public void Dispose()
    {
        Console.WriteLine("Resource disposed.");
    }
}