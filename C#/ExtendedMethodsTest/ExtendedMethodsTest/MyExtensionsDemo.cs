using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensions
{
    static class StringExtension
    {
        public static string Ten(this String msg) => msg.Substring(0, 10);
        public static string Five(this String msg) => msg.Substring(0, 5);
        public static string AddElipsis(this String msg) => msg + "...";
        public static string AddElipsis(this String msg, string elipsis) => $"{msg}{elipsis}";
    }
    class MyExtensionsDemo
    {
        static void Main()
        {
            //확장 메서드 : 기존 형식에 메서드를 추가하는 기능으로
            //확장 형식의 인스턴스 메서드로 사용
            string message = "안녕하세요. 반갑습니다. 또 만나요.";
            //10자리 자르고 다시 5자리 자름. 메서드 체이닝으로 결과에 대해 연속 실행.
            Console.WriteLine(message.Ten().Five().AddElipsis()); 
            //...을 입력 값 ___을 받아 바꿔서 출력
            Console.WriteLine(message.Ten().Five().Five().AddElipsis("___")); 
            Console.WriteLine(message.Five());

        }
    }
}
