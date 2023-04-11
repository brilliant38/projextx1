using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.C_Sharp_Lecture
{
    class Variable
    {
        static void main()
        {
            /*C# 교과서 05. 변수 만들기
             * 변수(Variable): 프로그램에서 사용할 데이터를 임시로 저장해 놓는 그릇
             */

            int number; //정수형 변수 선언
            number = 1234;
            Console.WriteLine("{0}", number);

            //리터럴
            Console.WriteLine(1234); //정수 리터럴
            Console.WriteLine(3.14F); // 실수 리터럴
            Console.WriteLine('A'); // 문자 리터럴
            Console.WriteLine("1234"); // 문자열 리터럴

            //[?] 변수(Variable): 프로그램에서 사용할 데이터를 저장해 놓는 그릇
            //[1] 변수 만들기(선언)
            int i;

            //[2] 변수에 값을 저장하기 (대입, 할당)
            i = 1234;

            //[3] 변수에 들어 있는 값 사용하기 (참조)
            Console.WriteLine(i);//1234

            //변수 선언과 동시에 초기화

            i = 7;
            Console.WriteLine("{0}", i);
            
            i = 1_234;

            //[?]콤마를 사용하여 동일 데이터 형식을 갖는 변수 여러 개 만들기
            //[1]콤마(,) 기호로 여러 개의 변수 선언

            int a, b, c;

            a = b = c = 10;

            Console.WriteLine("{0},{1},{2}", a,b,c);

            //상수 : 변하지 않는 변수, 읽기 전용 변수
            const int MAX = 100; // 정수이자 상수인 변수

            //MAX = 1_234; //상수에 대입 불가.
            Console.WriteLine("{0}", MAX);

            const double PI = 3.141592; //상수 PI

            //PI = 1234; //상수 변경 에러

        }
    }
}
