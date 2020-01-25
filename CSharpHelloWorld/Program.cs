using CSharpHelloWorld.ControlFlow;
using System;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Random Class Example 1
            var random = new Random();
            //for (var i = 0; i < 10; i++)
            //    /*Console.WriteLine(random.Next(1,10));*/

            //    Console.Write((char)random.Next(97, 122));
            //Console.WriteLine();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);



            #endregion


        }

    }
}
