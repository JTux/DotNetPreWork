using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }

            number = 100;

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }

            number = 500;
            while (number <= 525)
            {
                Console.WriteLine(number);
                number++;
            }

            number = 100;
            for (int i = 0; i <= number; i += 5)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= number; i++)
            {
                if (i % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
