using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelloWorld.Demo
{
    class DemoSummarisingText
    {
        public void SampleSumerize()
        {
            var sentence = "This is going to be a really really really really really really really really  a good day and good news";
            var summary = SummerizeText(sentence, 30);
            Console.WriteLine(summary);
        }

        /*
         Jika ingin method bisa di akses dari luar class, gunakan public di paling depan
         */
        static string SummerizeText(string text, int maxLength =20)
        {
            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";


        }
    }
}
