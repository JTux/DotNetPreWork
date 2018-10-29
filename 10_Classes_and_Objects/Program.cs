using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            dougDonut.Filling = "Cherry";
            dougDonut.Price = 3m;
            dougDonut.Type = "Normal";
            dougDonut.IsSpecial = true;

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2m;
            chrisDonut.Type = "Small";
            chrisDonut.IsSpecial = false;

            nickDonut.Filling = "Chocolate";
            nickDonut.Price = 3m;
            nickDonut.Type = "Normal";
            nickDonut.IsSpecial = true;

            Console.WriteLine(nickDonut.Filling);
            Console.ReadLine();
        }
    }
}
