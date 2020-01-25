using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelloWorld.Demo
{
    class DemoStringBuilder
    {
        public void SampleStringBuilder()
        {
            var builder = new StringBuilder("Hello Dunia");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)

                //Replace()
                .Replace('-', '+')

                //Remove()
                .Remove(0, 10)

                //Insert()
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
