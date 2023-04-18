using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//네임스페이스 : 클래스명 충돌 방지
namespace OOPTest
{   
    //인터페이스: 표준, 다중상속
    interface IStandard { void Run(); } //추상화
    //클래스 : 설계도
    class Car : IStandard //상속
    {
        //캡슐화
        //private Member Variables;
        private string name;
        private string[] names;
        private readonly int _Length;

        public Car()
        {
            this.name = "좋은차"; // 필드를 기본값으로 초기화
        }
        public Car(string name) //생성자 : 조립/시동, 필드 초기화
        {
            this.name = name;
        }
        public Car(int length)
        {
            this.Name = "좋은차";
            _Length = length; // 읽기 전용 필드는 생성자에 의해서 초기화 가능
            names = new string[length]; // 넘겨온 값으로 요소 생성
        }
        //메서드
        public void Run() => Console.WriteLine("{0} 자동차가 달립니다.", name);
        
        //속성
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int Length { get { return _Length; } }

        //소멸자
        ~Car()
        {
            Console.WriteLine("{0} 자동차가 폐차됨.", name);
        }

        //인덱서
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        
        //반복기
        public IEnumerator GetEnumerator() 
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }

        //대리자
        public delegate void EventHandler();

        //이벤트
        public event EventHandler Click;

        public void Onclick()
        {
            if(Click != null)
            {
                Click();
            }
        }
    }

    class CarRepair
    {   
        //다형성(융통성)
        public CarRepair(IStandard car) => car.Run();
    }


    class Program
    {
        static void Main(string[] args)
        {
            //클래스, 생성자, 메서드 테스트
            Car campingCar = new Car("캠핑카");
            campingCar.Run();

            //속성 테스트
            Car sportsCar = new Car();
            sportsCar.Name = "스포츠카";
            sportsCar.Run(); //스포츠카 자동차가 달립니다.

            //인덱서 테스트
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //이터레이터 테스트
            foreach (string name in cars)
            {
                Console.WriteLine(name);
            }

            //대리자, 이벤트, 이벤트 처리기 테스트
            Car btn = new Car("전기자동차");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Onclick();

            //다형성 테스트
            new CarRepair(campingCar);
            new CarRepair(sportsCar);

        }
    }
}
