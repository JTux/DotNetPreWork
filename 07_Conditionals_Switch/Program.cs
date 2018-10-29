using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Conditionals_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            switch (inputName.ToLower())
            {
                case "fred":
                    Console.WriteLine("Hey Fred let's go golfing.");
                    break;
                case "karl":
                    Console.Write("Let's hang.");
                    break;
                case "john":
                    Console.WriteLine("Sorry, I am busy right now.");
                    break;
                default:
                    Console.WriteLine("Hey " + inputName + " can I call you back in a minute?");
                    break;
            }

            Console.ReadLine();
        }
    }
}
