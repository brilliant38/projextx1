using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSumEven
{
    class ForSumEven
    {
        static void Main(string[] args)
        {
            int n = 5;
            int sum = 0;

            for(int i=1; i<=n; i++) //n == 5이므로 i가 0,1,2,3,4 일때
            {
                if(i%2 == 0)
                {
                    sum += i; //짝수 0,2,4 더하기
                }
            }



            Console.WriteLine($"1부터 {n}까지 짝수의 합: { sum}");

            Console.WriteLine("----------------------------------------");

            int sum1 = 0;

            for(int i =1; i<=100; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 += i;
                }
            }

            Console.WriteLine($"1부터 100까지 짝수의 합: { sum1}");


            int sum3 = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    sum3 += i;
                }
            }
            Console.WriteLine($"1부터 100까지 3의 배수이고 4의 배수인 수의 합: { sum3}");
        }
    }
}
