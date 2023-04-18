using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{   
    public enum CarType { 전기, 내연기관}

    public abstract class CarBase
    {
        public abstract void Left(); // 추상 클래스의 추상 메서드, 본문 x, 시그니처 o => 표준(강제) => 인터페이스
        public void Back() => Console.WriteLine("후진하다.");

        protected string LeftMessage { get; set; } = "좌회전 하다."; //자식에게만 멤버가 노출 된다.
    }

    public class Car : CarBase //: Object 상속 항목이 모두 생략 되어 있다.
    {
        
        public CarType Style { get; private set; }
        public void Go() => Console.WriteLine("달리다.");

        public override void Left() //override 추상 메서드의 필 수 구 현 필요.
        {
            Console.WriteLine(base.LeftMessage);
        }
        public Car(CarType carType)
        {
            this.Style = carType;
        }
    }

    public class Benz : Car //sub : CarBase까지 상속 됨
    {
        public Benz() : this(CarType.내연기관) { }
        /*public Benz(CarType carType) //값을 넘겨주면 생성자 오버로딩 됨.
        {
            this.Style = carType;
        }*/
        public Benz(CarType carType) : base(carType) { } //생성자 오버로딩

    }
    public class Tesla : Car
    {
        //public CarType Style { get; set; } = CarType.전기;

        public Tesla() : this(CarType.전기) { }
        public Tesla(CarType carType) : base(carType) { } //생성자 오버로딩
    }

    public sealed class Future : Car //sealed 봉인 클래스 -> 상속 불가
    {
        public Future() : this(CarType.전기) { }
        public Future(CarType carType) : base(carType) { }
        public new void Go() //부모 클래스의 Go를 재정의 (new)
        {
            base.Go(); 
            Console.WriteLine("날다.");
        }
    }

    /*public class OtherFuture : Future
    {

    }*/

    class InheritanceTest : Object
    {
        static void Main()
        {
            (new Benz()).Go();
            (new Tesla()).Go();

            Console.WriteLine();

            Benz benz = new Benz();
            benz.Go();
            Console.WriteLine($"{benz.Style}");
            benz.Back();
            benz.Left();

            Console.WriteLine();

            Tesla tesla = new Tesla();
            tesla.Go();
            Console.WriteLine($"{tesla.Style}");
            tesla.Back();
            benz.Left();

            Console.WriteLine();

            Future future = new Future();
            future.Go();

            Console.WriteLine();
            

        }
    }
}
