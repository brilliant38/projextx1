using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class FunctionNote
    {
        //Main이 아닌 함수 선언
        //static void Sum(int first, int second) => Console.WriteLine("합계: "); 
        static void Sum(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine($"합계: {sum}"); 
        }
        //리턴이 있는 함수
        static int Sum1(int first, int second)
        {
            int sum = first + second;
            
            return sum;
        }

        // Main 함수 선언
        static void Main(string[] args) 
        {
            int first = Convert.ToInt32(args[0]);
            int second = Convert.ToInt32(args[1]);
            Console.WriteLine(Sum1(first, second));

            //FunctionNote.Sum(3,5); //함수 호출
            Console.WriteLine("--------------------");
            //Console.WriteLine($"합계: {FunctionNote.Sum1(3, 5)}");//리턴이 있는 함수 호출
        }
    }
}
