using System;

namespace InterfaceTest
{
    interface ICar
    {
        void Go(); //매개 변수도 없고 반환 값도 없는 Go()메서드 시그니처 선언
    }

    class Car : ICar
    {
        public void Go()
        {
            Console.WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 합니다.");
        }
    }
    class InterfaceTest
    {
        static void Main(string[] args)
        {
            //인터페이스: 특정 멤버가 반드시 구현되어야 함을 보증
            var car = new Car();
            car.Go();
        }
    }
}
