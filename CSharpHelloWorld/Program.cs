using CSharpHelloWorld.ControlFlow;
using System;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Demo For Loops

            for (var i = 1; i<= 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

          for (var i = 10; i >= 1; i--)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            #region Foreach Loops
            var name = "John Legend";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach(var character in name)
            {
                Console.WriteLine(character);
            }

            //--------------------------------------
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region While Loops
            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                //Cara Pertama
                //if (String.IsNullOrWhiteSpace(input))
                //    break;

                //Console.WriteLine("@Echo: " + input);

                //Cara Kedua
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                    break;

            }
            
            #endregion


        }

    }
}
