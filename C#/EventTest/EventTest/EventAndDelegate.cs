using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateDemo
{
    // 이벤트 구독자 (subsriber)
    class EventAndDelegate

    {
        static void Main()
        {
            //특정 상황이 발생 할 때 객체 또는 클래스에서 알림을 제공할 수 있도록 하는 멤버

            Car car = new Car();
            car.FuelEmptyReached += Car_FuelEmptyReached;//이벤트 추가
            car.FuelEmptyReached -= Car_FuelEmptyReached;//이벤트 삭제
            car.FuelEmptyReached += () => 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("연료부족!!!");
                Console.ResetColor();
            }; //람다식 구현
            car.Go();
            car.OnFuelEmptyReached();
            car.Go();
            car.OnFuelEmptyReached();
            /*car.Go();
            car.OnFuelEmptyReached();
            car.Go();
            car.OnFuelEmptyReached();
            car.Go();
            car.OnFuelEmptyReached();*/

        }

        //이벤트 처리기(핸들러)
        private static void Car_FuelEmptyReached()
        {
            System.Console.WriteLine("연료 부족");
        }
    }
}
