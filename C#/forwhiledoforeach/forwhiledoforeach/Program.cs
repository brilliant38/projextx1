using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forwhiledoforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //반복문: for문 (구간반복), while문 (조건반복), do문(실행반복), foreach문(배열반복)
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Hello");
            }

            int count = 0;
            while (count<3)
            {
                Console.WriteLine("안녕하세요.");
                count++; //3이 될 때까지 반복
            }

            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine("카운트: {0}", j); //실행문을 실행하고
                j++;
            }

            int c = 1;
            while(c<=3)
            {
                Console.WriteLine($"카운트:{c}");
                c++;
            }

            int index = 5;
            while(index > 0)
            {
                Console.WriteLine($"안녕하세요.{index}");
                index--;
            }

            //while 문을 사용하여 1부터 100까지의 합을 구하는 프로그램
            const int A = 100;
            int sum5 = 0;
            int i1 = 1;
            while(i1 <= A)
            {
                sum5 += i1;
                i1++;
            }
            Console.WriteLine($"1부터 {A}까지의 합: {sum5}");
            
            
            Console.WriteLine("------------------------------------");


            int count1 = 0;
            do
            {
                Console.WriteLine("안녕하세요");
                count1++;
            } while (count1 < 3);

            int sumx = 0;
            int ip = 1;
            do
            {
                sumx += ip;
                ip++;
            } while (ip <= 5);
            Console.WriteLine($"sumx: {sumx}");

            int ik = 1;
            int sump = 0;
            do
            {
                if (ik % 3 == 0 && ik % 4 == 0)
                {
                    sump += ik;
                }
                ik++;
            } while (ik <= 100);

            Console.WriteLine($"sump: {sump}");

            Console.WriteLine("------------------------------------");

            String[] names = { "C#", "ASP.NET" };
            foreach(String name in names)
            {
                Console.WriteLine(name);
            }

            String str = "ABC123";
            foreach(char g in str)
            {
                Console.WriteLine(g);
            }
        }
    }
}
