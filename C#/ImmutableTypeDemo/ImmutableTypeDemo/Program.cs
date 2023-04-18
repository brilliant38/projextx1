using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableTypeDemo
{   
    public class Circle
    {
        public int Radius { get; private set; } = 0; //외부에서 set 불가
        public Circle(int radius) => Radius = radius; //생성자로 값 초기화
        public Circle MakeNew(int radius) => new Circle(radius); //스스로 객체를 만들어서 리턴해 주는 메서드
    }

    class ImmutableTypeDemo
    {
        static void Main(string[] args)
        {   
            //1. 생성자를 통해서 반지름이 10인 Circle 객체 생성
            Circle circle = new Circle(10);
            Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");

            //2. 메서드를 통해서 반지름이 20인 Circle 객체 새롭게 생성
            circle = circle.MakeNew(20);
            Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");
        }
    }
}
