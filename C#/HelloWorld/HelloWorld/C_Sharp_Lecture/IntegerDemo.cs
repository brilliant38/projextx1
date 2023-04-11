using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.C_Sharp_Lecture
{
    class IntegerDemo
    {
        static void Main()
        {
            sbyte s = 127;
            short d = 32767;
            int a = 2147483647;
            long w = 9223372036854775807;

            int number = 1_234;

            Console.WriteLine("{0}", number);

            int min = Int32.MinValue;
            int max = Int32.MaxValue;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(long.MaxValue);
            
            //부호 없는 정수 데이터
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(byte.MaxValue);

            //double 키워드 : 실수형 데이터 형식
            double PI = 3.141592;
             PI = 3.14D;
             PI = 3.14d;

            Console.WriteLine(PI);

            // float
            float f = 3.14f;

            decimal m = 3.14m;

            Console.WriteLine(f);
            Console.WriteLine(m);


            int? x = null;


            

        }
    }
}
