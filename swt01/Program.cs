using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Calculator!");

            var uut = new Calculator();

            Console.WriteLine("\nTester Add-funktion");
            Console.WriteLine("Add({0}, {1}) = {2}", 3.5, 2.5, uut.Add(3.5, 2.5));

            Console.WriteLine("\nTester Subtract-funktion");
            Console.WriteLine("Subtract({0}, {1}) = {2}", 3.5, 2.5, uut.Subtract(3.5, 2.5));

            Console.WriteLine("\nTester Multiply-funktion");
            Console.WriteLine("Multiply({0}, {1}) = {2}", 3, 2, uut.Multiply(3, 2));

            Console.WriteLine("\nTester Power-funktion");
            Console.WriteLine("Add({0}, {1}) = {2}", 5, 2, uut.Power(5, 2));
        }
    }
}