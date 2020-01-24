using CSharpHelloWorld.Math;
using System;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Kenedy";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 5);
            Console.WriteLine(result);
        }
    }
}
