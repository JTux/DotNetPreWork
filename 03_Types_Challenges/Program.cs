using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int number2 = 2;
            Console.WriteLine(number2);

            string word;
            string word2 = "Second string";
            Console.WriteLine(word2);

            Console.WriteLine("This is " + word2);

            bool isTrue;
            bool isFalse = false;
            Console.WriteLine(isFalse);

            float number3;
            float number4 = 120.54f;
            Console.WriteLine(number4);

            double number5;
            double number6 = 60.26d;
            Console.WriteLine(number6);

            decimal number7;
            decimal number8 = 3.1415926535897932384626433m;
            Console.WriteLine(number8);

            string prompt = "I was born in the year ";
            int birthYear = 1995;
            Console.WriteLine(prompt + birthYear + ".");

            Console.ReadLine();
        }
    }
}
