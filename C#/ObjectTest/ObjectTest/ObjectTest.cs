using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest
{   
    public class ClassCode
    {

    }

    public class Car
    {
        public void Go() => Console.WriteLine("Run......");
        public override string ToString() => "My Car";
    }

    public class ClassOne
    {
        public static void Hi() => Console.WriteLine("Hi");
    }
    
    public class ClassTwo
    {
        public void Hi() => Console.WriteLine("Hi");
    }

    class ObjectTest
    {
        static void Main(string[] args)
        {
            //객체 생성
            ClassCode classCode = new ClassCode();
            classCode.GetHashCode();


            ClassCode classCode2 = new ClassCode();
            classCode2.GetHashCode();

            //자동차 Class로부터 car1,car2 두개의 객체가 만들어졌다.
            Car car1 = new Car();
            Car car2 = new Car();

            car1.Go();
            car2.Go();

            //정적 메소드 추가 객체 생성 필요없음
            ClassOne.Hi();

            //인스턴스 메소드 추가 객체 생성 해야함
            ClassTwo two = new ClassTwo();
            two.Hi();


        }
    }
}
