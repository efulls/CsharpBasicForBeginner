using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelloWorld.Demo
{
    class DemoString
    {
        public void SampleString()
        {
            var fullName = "Saeful Mahmud ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            //Console.WriteLine("Not Make Trim: '{0}'",fullName);
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            //Split Name Cara 1
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            //Split Name Cara 2
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            //Replace
            Console.WriteLine(fullName.Replace("Mahmud","Efull"));


            //Validasi string kosong atau hanya diisi spasi
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            //Konversi string ke int menggunakan ToByte karena hanya membutuhkan 4bite
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

        }
    }
}
