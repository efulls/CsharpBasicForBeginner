using System;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Penulisan yang benar
            byte b = 1;
            int i = b;
            Console.WriteLine(i);


            //Penulisan yang salah seperti ini, integer tidak bisa dikonversi ke byte 
            //int b = 1;
            //byte i = b;
        }
    }
}
