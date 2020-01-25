using CSharpHelloWorld.ControlFlow;
using System;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 19;
            
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }       
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }





            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);





            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn an beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Perfect to go to beach.");
                    break;
                default:
                    Console.WriteLine("i dont understand that season!");
                    break;
            }



        }
        
    }
}
