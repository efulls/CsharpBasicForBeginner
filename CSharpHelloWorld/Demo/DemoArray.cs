using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelloWorld.Demo
{
    class DemoArray
    {
        public void ArraySample()
        {
            var numbers = new[] { 1, 2, 5, 4, 20, 15, 33 };

            //length
            Console.WriteLine("Length: " + numbers.Length);

            //Clear from array 1 - 3
            Array.Clear(numbers, 1, 3);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Efect Of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            //Short()
            Array.Sort(numbers);

            Console.WriteLine("Efect od sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Referse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
