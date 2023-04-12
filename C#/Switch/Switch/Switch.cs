using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{   
    enum Color
    {
        Red = 10,
        Green,
        Blue = 20
    }
    class Switch
    {
        static void Main(string[] args)
        {
            //선택문 switch문 : switch와 case 그리고 default 키워드를 사용하여 다양한 조건 처리

            var n = 1;

            switch (n)
            {
                case 1:
                    Console.WriteLine("number 1");
                    break;
                case 2:
                    Console.WriteLine("number 2");
                    break;
            }

            Console.WriteLine("-------------------------------------");

            n = 2;

            switch (n)
            {
                case 1:
                    Console.WriteLine("number 1");
                    break;
                case 2:
                    Console.WriteLine("number 2");
                    break;
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("정수를 입력하세요.");
            int answer = Convert.ToInt32(Console.ReadLine());

            //선택문
            switch (answer)
            {
                case 1:
                    Console.WriteLine("1을 선택했습니다.");
                    break;
                case 2:
                    Console.WriteLine("2을 선택했습니다.");
                    break;
                case 3:
                    Console.WriteLine("3을 선택했습니다.");
                    break;
                default:
                    Console.WriteLine("그냥 찍으셨군요.");
                    break;

            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("오늘 날씨는 어떤가요? (맑음, 흐림, 비, 눈,...)");
            string weather = Console.ReadLine();

            //선택문
            switch (weather)
            {
                case "맑음":
                    Console.WriteLine("오늘 날씨는 맑군요.");
                    break;
                case "흐림":
                    Console.WriteLine("오늘 날씨는 흐리군요.");
                    break;
                case "비":
                    Console.WriteLine("오늘 날씨는 비가 오는군요.");
                    break;
                default:
                    Console.WriteLine("혹시 눈이 내리나요?");
                    break;

            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            char signalLight = 'R';
            string message = "";

            //선택문
            switch (signalLight)
            {
                case 'R':
                    message= "적색: 멈추세요";
                    break;
                case 'Y':
                    message = "황색 : 주의하세요.";
                    break;
                case 'G':
                    message = "녹색: 이동하세요.";
                    break;
                default:
                    message = "신호등 고장";
                    break;

            }
            Console.WriteLine(message);

            Console.WriteLine("-------------------------------------");

            var color = Color.Green;
            //선택문
            switch (color)
            {
                case Color.Red:
                case Color.Green:
                    Console.WriteLine("R 또는 G");
                    break;
                case Color.Blue:
                    break;
                default:
                    break;
            }
        }
    }
}
