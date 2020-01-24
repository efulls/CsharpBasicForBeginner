using CSharpHelloWorld.Math;
using System;

namespace CSharpHelloWorld
{
    public enum ShippingMethod
    {
        RegularAirmail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Menampilkan Enum berdasarkan  MethodName
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //Menampilkan Method Name Berdasarkan Enum
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //Menampilkan Enum menggunakan ToString
            Console.WriteLine(method.ToString());

            //Memparsing Method 
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
