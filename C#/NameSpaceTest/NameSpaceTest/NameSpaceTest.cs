using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foo;



namespace MyNamespace
{

    class NameSpaceTest
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("네임스페이스");

            Foo.Car car1 = new Foo.Car();
            car1.Go();

            var car2 = new Bar.Car(); //var는 대입 되는 객체의 타입을 자동으로 따라감.
            car2.Go();


        }
    }

}