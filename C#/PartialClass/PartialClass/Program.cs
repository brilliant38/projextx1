using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{   
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Person
    {
        public void Print() => Console.WriteLine($"{Name}: {Age}");
    }

    class Point
    {
        public readonly int x; //readonly면 필드는 외부로 공개 하되, 생성자로만 초기화 가능함.
        public readonly int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point MoveBy(int dx, int dy) //생성자의 반환 값을 나 자신(Point) 타입으로 지정
        {
            //x += dx;
            //y += dy;
            return new Point(x + dx, y + dy);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "C#";
            person.Age = 20;

            person.Print();


            Point point = new Point(0,0);
            point.MoveBy(100, 200);
            Console.WriteLine($"X:{point.x},Y:{point.y}");//100, 200

            Console.WriteLine();

            var point2 = new Point(0, 0).MoveBy(100, 100).MoveBy(50, 50); //.로 메소드를 연속 실행 가능함.
            Console.WriteLine($"{point2.x},{point2.y}");

        }
    }
}
