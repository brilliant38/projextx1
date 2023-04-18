
#define RELEASE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace AttributeAndReflectionTest
{
    public class LuxuryAttribute : Attribute 
    {
        public LuxuryAttribute() => Console.WriteLine("럭셔리!!");
    } //Attribute를 상속하여 특성 생성
    //[LuxuryAttribute] 
    [Luxury]
    class Car
    {
        //[Obsolete("다음 버전에 제거 될 예정이니 Auto()를 사용하세요.")] //더 이상 사용하지 않는 요소에 대한 알림
        //public void Manual() => Console.WriteLine("수동 운전");
        public void Auto() => Console.WriteLine("자동 운전");
        [Conditional("DEBUG")] public void Test() => Console.WriteLine("테스트 운전");
        [Conditional("RELEASE")] public void Test2() => Console.WriteLine("테스트 운전");
    }
    class AttributeAndReflectionTest
    {
        static void Main()
        {
            //프로그램에서 형식, 멤버 및 다른 엔터티에 대한 추가 선언 정보를 지정 가능
            //CLR은 자기 자신에 대한 내용을 노출 시켜주는 API를 제공

            Car car = new Car();
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);
            car.Test();
            car.Test2();
            car.Auto(); //car.manual();
            car.Auto();

            //리플렉션
            var carType = (new Car());
            Type myCar = carType.GetType();
            MethodInfo info = myCar.GetMethod("Auto");
            info.Invoke(carType, null);

        }
    }
}
