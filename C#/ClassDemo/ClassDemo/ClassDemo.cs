using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class ClassDemo
    {   
        struct Point { public int X; public int Y; }

        enum Animal { Mouse, Tiger}

        class Square
        {
            public int Width;
            public int Height;
            public static string Creator;

        }

        static void Main(string[] args)
        {


            //구조체
            Int32 number = 1_234;

            Point point;
            point.X = 100; 
            point.Y = 200;
            Console.WriteLine($"{point.X},{point.Y}");
            
            //열거형
            Console.WriteLine($"{Animal.Mouse},{Animal.Tiger}");

            //클래스

            string creator = Square.Creator; //->static이므로 인스턴스 생성 필요없이 사용 가능한 필드.
            creator = "RedPlus";
            Console.WriteLine($"{creator}");

            Square square = new Square();
            //square.Width = 100; // CS0165: 할당되지 않은 'square' 지역 변수를 사용했습니다.

            square.Width = 100;
            square.Height = 200;

            Console.WriteLine($"{square.Width},{square.Height}");

            //Built-In
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.NewLine); //빈 줄 추가
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.Version);

            //Random

            Random random = new Random();
            Console.WriteLine();
            Console.WriteLine("---------");
            int a = random.Next();
            int b = random.Next(1,6);
            int c = random.Next();

            Console.WriteLine($"{a},{b},{c}");

            //string
            string s = "Foo";
            int x = 1_234;
            object p = 1234;
            string l = p as string; // as연산자는 해당 type으로 변환 가능시 변환 된 값을 넣어주고, 아니면 null을 넣어줌.
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine(s is string); //is 연산자는 해당 타입인지 확인해줌.
            Console.WriteLine(x is string);
            Console.WriteLine(p is string);
            Console.WriteLine(l);



        }
    }
}
