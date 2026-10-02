using System;

internal class ControlFlow2
{
    public void Run()
    {
        Console.WriteLine("Loops Practice");

        Console.WriteLine("\nFor loop");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }


        Console.WriteLine("\nWhile loop");

        int x = 1;

        while (x <= 5)
        {
            Console.WriteLine(x);
            x++;
        }


        Console.WriteLine("\nDo while");

        int y = 1;

        do
        {
            Console.WriteLine("Hello " + y);
            y++;
        }
        while (y <= 3);


        Console.WriteLine("\nForeach");

        string[] cities = { "Karachi", "Lahore", "Islamabad" };

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }


        Console.WriteLine("\nBreak");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);

            if (i == 4)
            {
                break;
            }
        }


        Console.WriteLine("\nContinue");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                continue;
            }

            Console.WriteLine(i);
        }


        Console.WriteLine("\nNested loop");

        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 2; j++)
            {
                Console.WriteLine(i + " " + j);
            }
        }


        Console.WriteLine("\nSmall practice");

        int total = 0;

        for (int i = 1; i <= 5; i++)
        {
            total = total + i;
        }

        Console.WriteLine("Total: " + total);
    }
}