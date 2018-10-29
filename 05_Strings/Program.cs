using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string wholeName = "Joshua Tucker";

            string first = "The cars we sell are";
            string second = "BMW, Lexus, and Mercedes.";

            Console.WriteLine(first + " " + second);
            Console.WriteLine("{0} {1}", first, second);
            Console.WriteLine($"{first} {second}");

            Console.ReadLine();
        }
    }
}
