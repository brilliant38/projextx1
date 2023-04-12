using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //[1] System.Math Class
            //Static Member
            Console.WriteLine(Math.PI); 
            Console.WriteLine(Math.Max(5,3));
            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            //[2] System.Random Class
            //Instance Member

            Random random = new Random();
            Console.WriteLine(random.Next(1, 11));
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Random dice = new Random();
            Console.WriteLine(dice.Next(1, 7));
            Console.WriteLine(dice.Next(1, 7));
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            var dice1 = new Random();
            Console.WriteLine(dice1.Next(1, 7));
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }
    }
}
