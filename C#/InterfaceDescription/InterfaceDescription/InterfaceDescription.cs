using System;

namespace InterfaceDescription
{
    public interface ICarStandard //C# 인터페이스명은 I로 시작한다.
    {
        void Left();
    }

    public abstract class KS
    {
        public abstract void Back();// 이 메소드는 무조건 상속해라
        public void Fly() => Console.WriteLine("날다."); //추상 클래스는 자체 실행가능 메소드도 가질 수 있음.
    }
    partial class Mycar : KS
    {
        public override void Back() => Console.WriteLine("후진"); //추상 메소드의 구현 시에는 반드시 override 붙여야 함.

    }
    partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");

        public void Right() => Console.WriteLine("우회전");
    }
    sealed class Car : MyCar, ICarStandard //봉인 클래스이므로 상속 불가, 인터페이스는 다중 구현 가능
    {
        public void Left() => Console.WriteLine("좌회전");

        public void Run() => Console.WriteLine("직진");
    }

    //class SpyCar : Car { }

    class InterfaceDescription
    {
        static void Main()
        {
            Car car = new Car();
            car.Run();
            car.Right(); //상속 받은 메소드
            car.Back();
            car.Left();
            car.Fly();
            //SpyCar spy = new SpyCar(); spy.Run();
        }
    }
}
