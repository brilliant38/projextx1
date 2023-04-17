using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{   
    class Car
    {
        //public string name;
        //private string name;
        /*public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }*/

        //public string Name { get; set; } = "My Car"; //최종 선언 방식
        public string Name { get; private set; } = "My Car"; // 접근 제한 가능
    }

    class Program
    {   
        static void Main(string[] args)
        {
            //속성 : 클래스 안에 선언된 필드의 내용을 설정 하거나 참조 할 때 사용하는 코드 블록을 속성이라 함.
            //필드의 값을 읽거나 쓰거나 계산하는 방법을 제공하는 클래스의 속성을 나타내는 멤버
            //개체의 필드 중에서 외부에 공개 하고자 하는 방법
            //세련되지 못한 코드. 마치 자동차 내부가 외부에 드러나는 것과 같음.
            //닷넷 생태계에서는 모든 속성이 첫문자가 대문자여야 한다.
            Car car = new Car();
            //car.Name = "My Car";
            //Console.WriteLine(car.Name);

            //car.SetName("My Car");
            //car.GetName();

            //car.Name = "Your Car"; //변경 가능
            Console.WriteLine(car.Name);

            //Car car1 = new Car() { Name = "My bus" };
            //Console.WriteLine(car1.Name);

            var person = new { Name = "Red", Age = 21 }; //익명 객체 생성
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

        }
    }
}
