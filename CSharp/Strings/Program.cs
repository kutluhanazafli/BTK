using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Kutluhan";

            int result = sentence.Length;
            Console.WriteLine(result);

            var result2 = sentence.Clone();
            Console.WriteLine(result2);

            sentence = "My name is Kutluhan Azafli";

            bool result3 = sentence.EndsWith("i");
            bool result4 = sentence.StartsWith("My name");

            Console.WriteLine(result3);
            Console.WriteLine(result4);

            var result5 = sentence.IndexOf("name");
            Console.WriteLine(result5);

            var result6 = sentence.IndexOf(" ");
            Console.WriteLine(result6);

            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result7);

            var result8 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result8);

            var result9 = sentence.Substring(3,4);
            Console.WriteLine(result9);

            var result10 = sentence.ToLower();
            Console.WriteLine(result10);

            var result11 = sentence.ToUpper();
            Console.WriteLine(result11);

            var result12 = sentence.Replace(" ", "-");
            Console.WriteLine(result12);

            var result13 = sentence.Remove(2,5);
            Console.WriteLine(result13);


            Console.ReadKey();
        }

        private static void Intro()
        {
            string city = "Ankara";
            string city2 = "İstanbul";

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("{0} {1}", city, city2);
        }
    }
}
