using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakContinueGoto
{
    class BreakContinueGoto
    {
        static void Main(string[] args)
        {
            //break문: for, while, do 구문을 빠져나가는 역할
            for (int i = 0; i < 100; i++)
            {
                if (i==5)
                {
                    break; // i가 5일때 for문 종료
                }
                Console.Write($"{(i+1)}번 반복\t");
            }
            Console.WriteLine();

            //무한 루프
            int j = 0;
            while (true)
            {
                if (j==5)
                {
                    break;
                }
                Console.Write($"{(j + 1)}번 반복\t");
                j++;
            }
            Console.WriteLine();

            //Continue문: 반복문에서 아래 실행문을 실행하지 않고, 다음 구문(조건절)으로 이동

            //[!]1~100까지 정수 중 3의 배수를 제외한 수의 합
            int sum = 0;
            for(int i=1; i<=100; i++)
            {
                if (i%3 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("합:{0}",sum);



        }
    }
}
