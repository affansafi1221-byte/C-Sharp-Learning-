// Program.cs
using CSharpFundamentals._03_Methods;
using CSharpFundamentals.Basics;
using System.ComponentModel.DataAnnotations;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            // Variable.Run();
            Important important = new Important(1001);
            important.Run();
        }
    }
}