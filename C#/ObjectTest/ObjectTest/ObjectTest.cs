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
            


        }
    }
}
