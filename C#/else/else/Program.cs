using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @else
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 59;
            if( score == 60)
            {
                System.Console.WriteLine("합격");
            }
            else
            {
                System.Console.WriteLine("불합격");
            }
            Console.WriteLine("--------------------------------------------------");

            int score2 = 90;
            if (score2 >= 90)
            {
                System.Console.WriteLine("A");
            }
            else if (score2 >= 80)
            {
                System.Console.WriteLine("B");
            }
            else if (score2 >= 70)
            {
                System.Console.WriteLine("C");
            }
            else if (score2 >= 60)
            {
                System.Console.WriteLine("D");
            }
            else
            {
                System.Console.WriteLine("F");
            }



        }
    }
}
