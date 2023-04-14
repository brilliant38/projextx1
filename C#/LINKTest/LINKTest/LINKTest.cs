using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINKTest
{
    class LINKTest
    {
        static void Main(string[] args)
        {
            //LINQ: C# 언어에 직접 쿼리 기능을 통합하는 방식을 기반으로 하는 기술 집합 이름
            //메서드 syntax
            int[] numbers = { 1,2,3,4,5};
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum); //for, if는 SideEffect가 발생 할 가능성이 높음(생각지 못한 예외)

            Console.WriteLine();

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Average()); //-> Linq에서 제공해주는 확장 메서드

            Console.WriteLine();
            Console.WriteLine(numbers.Count()); 
            Console.WriteLine(numbers.Average());

            Console.WriteLine("--");
            Console.WriteLine(numbers.Where(n=> n%2 ==0));
            Console.WriteLine(numbers.Where(n => n % 2 == 0).ToList());
            //Goes to
            //Arrow, Give me
            Console.WriteLine();
            Console.WriteLine(numbers.Where(n => n % 2 == 0));
            Console.WriteLine(numbers.Where(number => number % 2 == 0));

            int[] a = { 1,2,3,4,5};

            Console.WriteLine();
            Console.WriteLine(a.Select(x => x));

            a.Select(x => { return x; });
            a.Select(x => { return x * 2; });

            IEnumerable<int> newNumbers = numbers.Where(n => n % 2 == 0 );
            newNumbers.ToList();


            List<string> techs = new List<string>();
            techs.Add("C#");
            techs.Add("ASP.NET");
            techs.Add("Blazor");

            Console.WriteLine(techs);

            techs.OrderBy(t => t); //a,b,c순 정렬
            techs.OrderByDescending(t => t); //c,b,a순 정렬
            techs.OrderByDescending(t => t.Length > 1); //글자 길이 1초과


            var numberz = Enumerable.Range(1, 100);

            numberz.Where(n => n % 2 == 0);
            numberz.Where(n=>n%2==0).Sum();

            numberz.OrderByDescending(n => n);
            numberz.OrderByDescending(n => n).Where(x => x % 2 == 0).Take(3); // 역순 정렬해서 짝수인 숫자 3개만

            //쿼리식으로도 가능 (쿼리 syntax)
            var q = from n in numbers
                    where n % 2 == 0
                    select n; 


        }
    }
}
