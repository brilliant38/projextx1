using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class ExceptionTest
    {
        static void Main(string[] args)
        {
            //문법 오류
            //잘못된 명령어를 입력
            //타이핑의 실수

            //런타임 오류
            //알고리즘 오류

            //throw (new Exception()); 무조건 예외 객체 Throw
            //throw (new ArgumentException()); 동일.
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("에러가 발생 했습니다.");
                //Console.WriteLine(ex.Message); // 에러 사유 구문만 출력
                Console.WriteLine(ex); //자세한 에러 메세지 출력 = ToString
            }


            String inputNumber = "3.14";
            int number = 0;
            try
            {
                number = Convert.ToInt32(inputNumber);
                Console.WriteLine($"입력한 값: {number}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"에러 발생: {fe.Message}"); //예외처리 클래스가 담고있는 정보
                Console.WriteLine($"{inputNumber}는 정수여야 합니다."); // 직접 입력한 예외처리
                
            }

            try
            {
                int now = DateTime.Now.Second;
                Console.WriteLine($"[0] 현재 초: {now}");

                int result = 2 / (now % 2);
                Console.WriteLine("[1] 홀수 초에서는 정상 처리");
            }
            catch
            {
                Console.WriteLine("[2] 짝수 초에서는 런타임 에러 발생 처리");
            }

            int x = 5;
            int y = 0;
            int r;

            try
            {
                r = x / y;
                Console.WriteLine($"{x}/{y} ={r}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생: {ex.Message}");

            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }


            Console.WriteLine("[1] 시작");
            try
            {
                Console.WriteLine("[2] 실행");
                
            }
            finally
            {
                Console.WriteLine("[3] 종료");
            }


            int a = 3;
            int b = 0;

            try
            {
                a = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외(에러)가 발생됨. {ex.Message}");

            }
            finally
            {
                Console.WriteLine("try 구문을 정상 종료합니다.");
            }


            try
            {
                throw new Exception("내가 만든 에러");
            }
            catch (Exception e)
            {
                Console.WriteLine($"예외(에러)가 발생됨. {e.Message}");

            }
            finally
            {
                Console.WriteLine("try 구문을 정상 종료합니다.");
            }


        }
    }
}
