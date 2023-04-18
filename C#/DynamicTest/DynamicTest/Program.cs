using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTest
{
    public class Program
    {
        public static void Main()
        {
            //런타임에 데이터 형식이 결정 되는 모든 형식을 담을 수 있는 특수한 유형의 형식
            dynamic x;
            x = 1_234;
            Console.WriteLine($"{x} - {x.GetType()}");

            x = "Dynamic Type!";
            Console.WriteLine($"{x} - {x.GetType()}" );
            //Console.WriteLine($"{x} - {x.xxxxxxx()}" );//런타임 시에 에러가 난다.

            string ss = "Hello";
            Console.WriteLine(ss);

            var vs = "Hello";
            Console.WriteLine(vs.Length);

            dynamic ds = "Hello"; 
            Console.WriteLine(ds.Length);

            //vs와 dynamic은 동일하지만, 다이나믹 타입은 인텔리센스의 가이드 지원이 안된다.
        }
    }
}
