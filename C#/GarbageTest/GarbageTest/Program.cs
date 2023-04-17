using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageTest
{
    class Car
    {
        private string name;
        public Car() : this("기본 자동차") { }

        public Car(string name)
        {
            this.name = name;
            Console.WriteLine($"[1] {this.name} 생성, 조립, 시동");
        }
        public void Go() => Console.WriteLine($"[2] {this.name} 달리다.");
        ~Car()//있는 것만 알고 사실 안 써도 됨. GC가 알아서 객체 제거해 줌.
        {
            Console.WriteLine($"[3] {this.name} 소멸");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Go();
            Car car2 = new Car("캠핑카");
            car2.Go();
        }
    }
}
