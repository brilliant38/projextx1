using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextBook
{   
    enum Animal
    {
        Mouse, Cow, Tiger
    }

    enum Animal1
    {
        Mouse, Cow = 5, Tiger //인덱스를 cow부터 5번 이후로 밀어버린다.
    }

    class EnumerationTextBook
    {
        static void Main()
        {   
            //열거형 Enum: 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수 집합을 정의

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"{nameof(ConsoleColor.Yellow)} & {nameof(ConsoleColor.White)}");
            Console.ResetColor();

            Animal animal = Animal.Tiger;
            Console.WriteLine(animal); //animal에 저장된 값이 리턴됨
            Console.WriteLine((int)animal); //ENUM은 배열로 관리 되므로 인덱스 번호가 리턴됨

            //ENUM의 문자열 리턴
            Console.WriteLine(nameof(Animal.Mouse));

            Animal1 tiger = Animal1.Tiger;
            Console.WriteLine((int)tiger);

            switch (animal) //swtich에서 열거형으로 즉시 템플릿 호출 가능.
            {
                case Animal.Mouse:
                    break;
                case Animal.Cow:
                    break;
                case Animal.Tiger:
                    break;
                default:
                    break;
            }
        }
    }
}
