using System;
using static System.Console;

namespace 비트연산자
{
    class 비트연산자
    {
        static void Main(string[] args)
        {
            //& 연산자 둘 다 1인경우에만 1을 반환하는 연산자
            byte x = 0b1010;
            byte y = 0b1100;

            WriteLine($"  {Convert.ToString(x, 2)}->{x}");
            WriteLine($"  {Convert.ToString(y, 2)}->{y}");
            WriteLine($"------------");
            WriteLine($"  {Convert.ToString(x & y, 2)}->{x & y, 2}");

            // | 연산자: 비트 OR 연산자(하나라도 1이라면 1을 반환)
            WriteLine($"------------");
            WriteLine($"  {Convert.ToString(x | y, 2)}->{x | y,2}");
            
            // ^ 연산자: 비트 XOR 연산자 (서로 다르면 1을 반환)
            WriteLine($"------------");
            WriteLine($"  {Convert.ToString(x ^ y, 2)}->{x ^ y,2}");
            WriteLine($"------------");

            // ~ 연산자: 비트 NOT 연산자 (1 <-> 0, 비트 반전)

            x = 0b00001010;
            WriteLine($"  {Convert.ToString(x, 2).PadLeft(8,'0')}->{x,3}");
            WriteLine($"------------");
            WriteLine($"  {Convert.ToString((byte)~x,2).PadLeft(8,'0')}->{~x,3}");
        }
    }
}
