using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.C_Sharp_Lecture
{
    class ExceptNumberDataType
    {
        static void Main()
        {
            //숫자 이외의 데이터 형식 : bool, char, string 등의 키워드로 숫자 이외의 데이터 저장
            //char grade = 1234;
            //char grade = "AAA";
            char grade = 'A';
            Console.WriteLine(grade);
            //char kor = '가';
            //char es = '가';

            //문자열 string
            //string hi = 1234;
            string hi = "Hello world";
            Console.WriteLine(hi);

            //@""는 여러열의 문자열을 전부 저장한다.
            string multiLines = @"
                안녕하세요
                반갑습니다.
                ";
            Console.WriteLine(multiLines);
            //StringInterpolation
            //문자열 보간법
            Console.WriteLine("{0},{1}", "hello", "world");

            $"{1234} is {"number"}"

            int number = 3;
            string result = "홀수";
            Console.WriteLine($"{number}은(는) {result}입니다.");

            $"{number}은 {result}입니다."
            //PlaceHolder
            "Hello" + ", " + "World";

            //Sgring.Format() 메서드 : 문자열 연결 관련 주요 기능 제공
            string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요.");
            Console.WriteLine(msg);

            //문자열 보간
            string message = "String Interpolation";
            Console.WriteLine("Message:{0}", message);
            Console.WriteLine("Message:" +  message);
            Console.WriteLine(String.Format("Message:{0}", message));
            Console.WriteLine($"Message: {message}");


            
        }
    }
}
