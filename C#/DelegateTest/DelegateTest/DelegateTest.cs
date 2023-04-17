using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class DelegateTest
    {
        static void GoForward() => Console.WriteLine("직진");
        static void GoLeft() => Console.WriteLine("좌회전");
        static void GoFast() => Console.WriteLine("과속");
        //static void GoRight() => Console.WriteLine("우회전");

        delegate void CarDriver();

        static void Main(string[] args)
        {
            //대리자 : 매개 변수 목록 및 반환 형식이 있는 메서드에 대한 참조(포인터)를 나타내는 형식

            //자동차의 대리운전

            //메서드의 매개 변수에 메서드 자체를 전달 가능
            //내장 API에서 많이 사용하고 있음.

            //[1] 내가 직접 운전했다.
            //GoForward();


            //[2] 대리 운전
            //CarDriver goHome = new CarDriver(GoForward);
            CarDriver goHome = GoForward;
            goHome += GoLeft; //실행 할 메소드 추가
            goHome += GoFast; //실행 할 메소드 추가
            goHome -= GoFast; //실행 할 메소드 제거
            goHome += delegate { Console.WriteLine("우회전"); }; //실행 할 무명 메서드 / 익명 함수 추가
            goHome += () => Console.WriteLine("후진"); //람다 식
            //goHome.Invoke();
            goHome();

            Console.WriteLine("---------");

            // 내장된 대리자 형식을 통해서 직접 대리자 개체 생성 : Func<T>, Action<T>, Predicate<T>,...
            Action driver = GoForward;
            driver += GoLeft;
            driver += delegate { Console.WriteLine("우회전"); }; //실행 할 무명 메서드 / 익명 함수 추가
            driver += () => Console.WriteLine("후진"); //람다식으로 호출하는 형식이 제일 깔끔하다.
            driver(); //트리거(방아쇠)
            Console.WriteLine("--------");

            Action go = () => Console.WriteLine("운전");
            go();

            Console.WriteLine("--------");
            RunLambda(() => Console.WriteLine("매개 변수로 람다 식 (함수 명, 무명 메서드) 전달"));
        }

        static void RunLambda(Action action) => action();
    }
}
