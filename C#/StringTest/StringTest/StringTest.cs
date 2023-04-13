using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    class StringTest
    {
        static void Main(string[] args)
        {
            string message = "hello world";
            Console.WriteLine(message.ToUpper());//대문자로 변경
            Console.WriteLine(message.ToLower());//소문자로 변경
            Console.WriteLine(
                message.Replace("hello","안녕하세요.").Replace("world", "세계."));

            String s1 = "안녕하세요."; //String 클래스 대문자
            string s2 = "반갑습니다."; //string 키워드 소문자
            Console.WriteLine($"{s1} {s2}");

            //문자열 연결 : 더하기 연산자, String.Concat()

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            string a1 = "안녕" + "하세요";
            string a2 = String.Concat("반갑", "습니다");
            Console.WriteLine($"{a1}, {a2}");

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            //문자열의 길이 : String.Length 속성

            string d1 = "Hello.";
            string d2 = "안녕하세요.";
            Console.WriteLine($"{d1.Length}, {d2.Length}");

            //[?]ToCharArray() 문자열을 문자 배열로 변환하기
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            string q = "안녕하세요.";
            char[] ch = q.ToCharArray();
            for (int i = 0; i <ch.Length; i++) 
            {
                Console.WriteLine(ch[i]); //안,...
            }

            //문자열 묶는 3가지 표현 방법 정리
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            var displayName = "";
            var firstName = "길동";
            var lastName = "홍";
            
            // 더하기 연산자
            displayName = "이름: " + lastName + firstName;
            Console.WriteLine(displayName); //이름: 홍길동
            
            // string.Format()
            displayName = string.Format("이름: {0}{1}",lastName,firstName);
            Console.WriteLine(displayName); //이름: 홍길동
            
            //문자열 보간법
            displayName = $"이름: {lastName}{firstName}";
            Console.WriteLine(displayName); //이름: 홍길동


            //문자열 비교법
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            string userName = "RedPlus";
            string userNameInput = "redplus";

            // == 연산자 사용
            if (userName.ToLower() == userNameInput)
            {
                Console.WriteLine("같습니다."); //대소문자 구분 안함
            }

            //string.Equals() 메서드 사용
            if (string.Equals(userName,userNameInput, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("같습니다.");     //string.Equals()는 대소문자 구분 안하지만,
                                                   //StringComparison.InvariantCultureIgnoreCase 대소문자 구별 무시
            }

            //문자열 값 비교: 대소문자 비교
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            string w1 = "Gilbut";
            string w2 = "gilbut";

            // 문자열 값의 대소문자를 구분
            if (w1 == w2)
            {
                Console.WriteLine("같다.");
            }
            else
            {
                Console.WriteLine("다르다."); //다르다 출력
            }

            //문자열의 대소문자를 구분하지 않고 비교
            if (w1.Equals(w2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("같다."); //같다 출력
            }




        }
    }
}
