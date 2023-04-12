//구조체 : 하나 이상의 변수를 묶어서 관리
using System;

struct Point
{
    public int X; //public (공용)
    public int Y;
    private int Z; //private (전용)

}

class StrucDemo
{
    static void Main(){
        Point point;
        point.X = 100;
        point.Y = 200;
        
        System.Console.WriteLine($"X: {point.X}, Y: {point.Y}");
        Console.WriteLine("--------");
        Console.WriteLine();
        Console.WriteLine(DateTime.Now.Year); 
        Console.WriteLine(DateTime.Now.Month); 
        Console.WriteLine(DateTime.Now.Day); 
        Console.WriteLine(DateTime.Now.Hour); 
        Console.WriteLine(DateTime.Now.Minute); 
        Console.WriteLine(DateTime.Now.Second); 
        Console.WriteLine(DateTime.Now.Millisecond);
        Console.WriteLine("--------");
        Console.WriteLine();

        DateTime now = DateTime.Now;
        //현재 시간
        Console.WriteLine(now);
        Console.WriteLine("--------");
        Console.WriteLine();
        //현재 시간  - 기준 시간
        
        //일 단위로 환산
        double ts = (DateTime.Now - (new DateTime(2020, 1, 1))).TotalDays;
        Console.WriteLine(ts);
        Console.WriteLine("--------");
        Console.WriteLine();

        //일자 기준으로 반올림
        Console.WriteLine(Math.Ceiling(ts));
        Console.WriteLine("--------");
        Console.WriteLine();


        var days = Math.Ceiling(ts);
        var goal = 10_000;
        Console.WriteLine($"{goal * days}");
        Console.WriteLine("--------");
        Console.WriteLine();

        TimeSpan ts1 = DateTime.Now - (new DateTime(2000, 1, 1));
        Console.WriteLine(ts1.TotalSeconds);
        Console.WriteLine(ts1.TotalDays);
        Console.WriteLine("--------");
        Console.WriteLine();

        //Char 구조체
        Console.WriteLine(Char.ToUpper('A'));
        Console.WriteLine(Char.IsWhiteSpace(' '));
        Console.WriteLine(Char.IsWhiteSpace('A'));
        Console.WriteLine(Char.IsDigit('1'));
        Console.WriteLine(Char.IsDigit('b'));
        Console.WriteLine(Char.IsLetterOrDigit(' '));
        Console.WriteLine("--------");
        Console.WriteLine();

        //Guid 구조체 (확률적으로 유일한 값 하나 생성)
        Console.WriteLine(Guid.NewGuid().ToString());
        Console.WriteLine("--------");
        Console.WriteLine();
    }
}