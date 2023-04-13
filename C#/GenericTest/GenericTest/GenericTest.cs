using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericTest
{
    class GenericTest
    {
        static void Main(string[] args)
        {
            //제네릭 : Cup<T>를 Cup of T로 발음하여 형식 매개 변수인 T에 따른 Cup 클래스의 개체 생성

            //Stack
            Stack stack = new Stack(); //아무 타입이나 받음 꺼낼때 unboxing이 필요
            stack.Push(100);
            
            Console.WriteLine(stack.Pop());
            
            Stack<int> stack1 = new Stack<int>(); //integer만 받음 꺼낼때 unboxing이 불필요하므로 빠름
            stack.Push(100);
            
            Console.WriteLine(stack.Pop());

            //List
            Console.WriteLine("--------");
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            //numbers.Add("a"); //input type 에러

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("--------");
            List<String> colors = new List<string>();
            colors.Add("red");
            colors.Add("green");
            colors.Insert(0, "blue");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            //enum
            Console.WriteLine("--------");
            Enumerable.Repeat(1, 10);
            numbers.AddRange(Enumerable.Range(1, 10));

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Dictionary (ket, value)
            Console.WriteLine("--------");
            Dictionary<int, string> todos = new Dictionary<int, string>();
            todos.Add(1, "C#");
            todos.Add(2, "ASP.NET");
            todos.Add(3, ".....");

            foreach (var item in todos)
            {
                Console.WriteLine($"{item.Key}.{item.Value}");

            }




        }
    }
}
