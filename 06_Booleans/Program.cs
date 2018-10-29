using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSad = false;
            bool isHappy = true;

            double value = 101d / 2d;

            if (value == 50)
            {
                Console.WriteLine(isHappy);
            }
            else if (value != 50)
            {
                Console.WriteLine(isSad);
            }

            Console.ReadLine();
        }
    }
}
