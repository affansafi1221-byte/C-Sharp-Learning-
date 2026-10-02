using System;
using System.Threading.Tasks;

namespace CSharpFundamentals._08_Async
{
    internal class Async
    {
        public void Run()
        {
            Console.WriteLine("Async Practice");

            Console.WriteLine("\n1. Simple Task");

            Task task = DoSomething();

            task.Wait();

            Console.WriteLine("Done");


            Console.WriteLine("\n2. Waiting");

            WaitSomeTime().Wait();


            Console.WriteLine("\n3. Get Number");

            int number = GetNumber().Result;

            Console.WriteLine("Number is: " + number);


            Console.WriteLine("\n4. Student");

            string studentName = GetStudentName().Result;

            Console.WriteLine(studentName);


            Console.WriteLine("\n5. Two Things");

            DoFirst().Wait();
            DoSecond().Wait();


            Console.WriteLine("\n6. Run Together");

            RunTogether().Wait();


            Console.WriteLine("\n7. Error Test");

            TrySomething().Wait();


            Console.WriteLine("\n8. Small API Example");

            GetUser().Wait();
        }

        private async Task DoSomething()
        {
            Console.WriteLine("Doing some work...");

            await Task.Delay(700);

            Console.WriteLine("Work finished");
        }

        private async Task WaitSomeTime()
        {
            Console.WriteLine("Start");

            await Task.Delay(1200);

            Console.WriteLine("After waiting");
        }

        private async Task<int> GetNumber()
        {
            await Task.Delay(500);

            int x = 25;
            int y = 10;

            return x + y;
        }

        private async Task<string> GetStudentName()
        {
            await Task.Delay(800);

            return "Safi";
        }

        private async Task DoFirst()
        {
            await Task.Delay(600);

            Console.WriteLine("First thing finished");
        }

        private async Task DoSecond()
        {
            await Task.Delay(900);

            Console.WriteLine("Second thing finished");
        }

        private async Task RunTogether()
        {
            Task tea = MakeTea();
            Task laptop = OpenLaptop();

            await Task.WhenAll(tea, laptop);

            Console.WriteLine("Everything is ready");
        }

        private async Task MakeTea()
        {
            await Task.Delay(1000);

            Console.WriteLine("Tea ready");
        }

        private async Task OpenLaptop()
        {
            await Task.Delay(500);

            Console.WriteLine("Laptop ready");
        }

        private async Task TrySomething()
        {
            try
            {
                await Task.Delay(300);

                int a = 10;
                int b = 0;

                int answer = a / b;

                Console.WriteLine(answer);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }

        private async Task GetUser()
        {
            Console.WriteLine("Connecting...");

            await Task.Delay(1000);

            Console.WriteLine("User found");
            Console.WriteLine("Name: Safi");
            Console.WriteLine("City: Karachi");
        }
    }
}