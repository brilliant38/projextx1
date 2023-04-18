using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{   
    public class Car
    {
        public string Name { get; private set; }
        public Car(string name) => Name = name;

        //변환 연산자 구현
        public static implicit operator Car(string name) => new Car(name); //생성자에게 재전송
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = "생성자에 직접 문자열을 전달함"; //전달되는 값의 타입에 따른 implicit가 구현되어 있는지 확인 함.
            Console.WriteLine(car.Name);
        }
    }
}
