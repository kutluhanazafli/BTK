using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();

            //DoWhileLoop();

            //ForEachLoop();

            if (IsPrimeNumber(1))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This isn't a prime number");
            }

            Console.ReadKey();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            if (number < 2)
            {
                result = false;
            }

            for (int i = 2; i < number-1; i++)
            {

                if (number%i==0)
                {
                    result = false;
                    break;
                }

            }

            return result;
        }


        private static void ForEachLoop()
        {
            string[] students = new string[3] {"Engin", "Derin", "Salih"};
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine("Number is {0}", number);
                number--;
            }

            Console.WriteLine("Finished!");
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
                Console.WriteLine("Finished!");
            }
        }
    }
}
