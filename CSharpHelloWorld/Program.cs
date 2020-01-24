using System;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            //Jika Semuanya Memenuhi Kondisi
            Console.WriteLine(c > b && c < a);
            //Jika Salah satu memenuhi kondisi
            Console.WriteLine(c > b || c < a);

        }
    }
}
