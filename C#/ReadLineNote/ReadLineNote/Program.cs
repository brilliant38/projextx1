using System;
class ReadLineDemo
{
    static void Main()
    {
        //Console.ReadLine(); //<- 이 시점에서 대기하는 효과.
        //Console.WriteLine(Console.ReadLine());
        /*Console.Write("이름: ______\b\b\b\b\b\b\b");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}님, 안녕하세요.");*/

        //int x = Console.Read();

        //Console.WriteLine(x); //아스키 코드 (ASCII)

        //Console.WriteLine(Convert.ToChar(x)); //실제 문자

        //long l = long.MaxValue;

        //int i = l;

        //int i = (int)l;

        //int i = int.MaxValue;
        //long l = i;

        //long l = (long)i;

        //Convert.Toxx 등으로 변환 가능

        //int b = 1234;
        //b.GetType()

        //object o = new object();
        //o.GetType()

        /*Console.WriteLine("정수: ");
        string num = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(num));*/

        int number = 10; // 0000 1010
        Convert.ToString(number, 2); //10진수를 2진수로

        Convert.ToString(number, 2).PadLeft(8, '0'); //10진수를 2진수로 8자리에 맞춰서.

        Convert.ToInt32("00001010", 2); // 2진수를 10진수로

        int b1 = 0b0010;
        int b2 = 0B1010;
        int b3 = 0b0000_1010;

        string name = "RedPlus";
        // var 키워드: 암시적으로 형식화 된 로컬 변수. 값의 형식에 따라 자동으로 타입이 정해짐.
        var name1 = "RedPlus";
        name.GetType();

        var c = 'C';

        //자바스크립트의 var에 해당하는 C# 키워드는 dynamic으로, 모든 타입을 다 담을 수 있는 변수형식이다.
        dynamic name5 = 1.0;

        int i = default;
        double d = default; //
        char c1 = default; //\0
        int i2 = default; //0
        string s = default; //null

        Console.ReadLine();
        Convert.ToInt32("1234");




    }
}