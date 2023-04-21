using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTest
{
    class TupleTest
    {
        static void Main(string[] args)
        {
            //튜플은 괄호 기호의 간단한 구문을 사용하여 하나 이상의 속성을 가지는 개체는 만드는 형식
            //새로운 클래스를 만들지 않고도 언어 차원에서 여러 개의 값을 전달 할 수 있는 기능을 제공하여 편리함을 줌
            //튜플 리터럴 Tuple Literal

            var r = (12, 34, 56);
            Console.WriteLine(r.Item1);
            Console.WriteLine(r.Item2);
            Console.WriteLine(r.Item3);

            Console.WriteLine();

            //기본: item1,item2
            var fhd = (1920, 1080);
            Console.WriteLine(fhd.Item1); 
            Console.WriteLine(fhd.Item2);

            Console.WriteLine();

            //키 : 값 형태
            var uhd = (Width: 3840, Height: 2160);
            Console.WriteLine($"{uhd.Width} + {uhd.Height}");

            //키,키 = 값, 값 형태
            (ushort Width, ushort Height) hd = (1366, 768);
            Console.WriteLine($"{hd.Height},{hd.Width},{hd.Width.GetType()}");

            Console.WriteLine();


            //튜플 리턴 형식
            (int, int) Tally1()
            {
                var s = (12, 3);
                return s;
            }
            var t1 = Tally1();
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);

            Console.WriteLine();

            //함수형으로도 선언 가능
            (int Sum, int Count) Tally2() => (45, 6);
            var t2 = Tally2();
            Console.WriteLine(t2.Sum);
            Console.WriteLine(t2.Count);

            Console.WriteLine();
            
            //변수 = 키,값
            var boy = (Name: "철수", IsStudent: true, OrderPrice: 1_000);
            Console.WriteLine($"{boy.Name}(초등학생: {boy.IsStudent}) - 주문: {boy.OrderPrice:C0}");

            Console.WriteLine();

            //default면 기본 값 할당
            (int, int) ZeroZero() => default;
            var t = ZeroZero();
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);

            Console.WriteLine();

            (int first, int second) NameTuple()
            {
                var x = (100, 200);
                return x;
            }

            var z = NameTuple();
            Console.WriteLine($"{z.first} , {z.second}");

            Console.WriteLine();
            (int p, int l) Tally3()
            {
                var k = (p: 12, l: 3);
                Console.WriteLine($"{k.p},{k.l}");
                return k;
            }
            var g = Tally3();
            Console.WriteLine(g.p);
            Console.WriteLine(g.l);

            //튜플 분해, 튜플 해체

            Console.WriteLine();
            var (sum1, count1) = Tally3();
            Console.WriteLine(sum1);
            Console.WriteLine(count1);


        }

        
        
    }
}
