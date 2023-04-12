using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            //배열(Array): 하나의 이름으로 같은 데이터 형식을 여러 개 보관해 놓는 그릇
            string arr = "C#8"; //그냥 문자열
            Console.WriteLine(arr);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);//인덱스가 배열 범위를 벗어난 예외
            //Console.WriteLine(arr[-1]);//인덱스가 배열 범위를 벗어난 예외
            

            //정수형 배열
            int[] numbers;
            //Console.WriteLine(numbers[0]);//개체 참조가 개체의 인스턴스로 설정되지 않았습니다.
            

            numbers = new int[3];
            Console.WriteLine(numbers[0]); //0
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] numbers1 = new int[3] { 10, 20, 30 }; //값과 함께 선언하는 방식 1
            int[] numbers2 = { 10, 20, 30 }; //값과 함께 선언하는 방식 2

            int[,] numbers3 = new int[2, 3]; //2차원 배열 선언 형식 1
            int[,] numbers4 = { { 10, 20, 30 },{ 40, 50, 60 } }; //2차원 배열 선언 형식 1
            
            for(int i=0; i< numbers4.GetLength(0); i++)
            {
                for(int j=0; j< numbers4.GetLength(1); j++)
                {
                    Console.Write($"{numbers4[i,j]}\t");
                }
                Console.WriteLine();
            }


            //문자열 배열
            //string[] names = { "C#", "ASP.NET" };
            string[] names = { "C#", "Windows Forms", "ASP.NET"};
            Console.WriteLine(names[0]);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            
            foreach (var name in names)
            {
                Console.WriteLine(name); //names내의 다음 name값이 있으면 출력, 없으면 종료
            }
        }
    }
}
