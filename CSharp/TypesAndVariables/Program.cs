﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

           //Value Types

           double number5 = 10.4;
           decimal number6 = 10;
           char character = 'A';
           bool condition = false;
           byte number4 = 255;
           short number3 = 32767;
           int number1 = 2147483647;   
           long number2 = 9223372036854775807;

           Console.WriteLine("Number1 is {0}", number1);
           Console.WriteLine("Number2 is {0}", number2);
           Console.WriteLine("Number3 is {0}", number3);
           Console.WriteLine("Number4 is {0}", number4);
           Console.WriteLine("Number5 is {0}", number5);
           Console.WriteLine("Number6 is {0}", number6);
           Console.WriteLine("Character is: {0}", (int) character);
           Console.WriteLine((int)days.Saturday);



            Console.ReadKey();

        }

        enum days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }


    }
}
