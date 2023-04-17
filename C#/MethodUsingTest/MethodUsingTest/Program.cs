using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodUsingTest
{
    public class Messenger
    {
        public void PrintMessage(string message, string prefix="", string suffix = "")
        {
            Console.WriteLine($"{prefix}{message}{suffix}");
        }
    }
    class MethodOverLoadNamed
    {
        static void Main()
        {
            //액세스 한정자, 반환값, 메서드 명, 매개변수로 구성된다.
            //메서드 명과 매개변수를 합쳐서 메서드 시그니처라고 한다. 오버로드 된 메서드끼리 구분하는 기준이 된다.
            //매개변수 전달의 3가지 방법 in, ref, out
            //in 입력, ref 입출력, out 출력모드
            //call by value 값에 의한 전달
            //call by reference 참조에 의한 전달
            string title;
            //Console.WriteLine($"[1] {title}");
            var car = new Car();
            //car.Map(title);
            //car.Map(ref title);
            //car.Map(out title);
            car.Map("홍길동", "백두산");
            //Console.WriteLine($"[3] {title}"); //변수 title의 값이 참조변경으로 변경 된 채로 출력 됨.

            Messenger messenger = new Messenger();
            messenger.PrintMessage("My"); //[A]
            messenger.PrintMessage(prefix: "Oh ", message: "My ");
            messenger.PrintMessage(prefix: "Oh ", message: "My ", suffix: "God");

        }
    }
    
    
}
