using System;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //var number = "1234";
                //int b = Convert.ToByte(number);
                //Console.WriteLine(b);
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Jumlahnya tidak bisa dikonversi ke byte");

            }
        }
    }
}
