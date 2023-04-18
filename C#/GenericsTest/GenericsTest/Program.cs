using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{   
    /*class Person
    {
        public string Name { get; set; }
    }*/

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Cup<T>
    {
        public T Content { get; set; }

    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>()
            {
                "Red", "Blue"
            };

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine();

            // 모델 클래스: Category, CategoryModel, CategoryViewModel....
            List<Person> people = new List<Person>
            {
                new Person {Name = "홍길동"},
                new Person {Name = "백두산"},
                new Person {Name = "임꺽정"}
            };

            foreach (var Person in people)
            {
                Console.WriteLine(Person.Name);
            }

            //컬렉션 이니셜 라이저를 사용하여 카테고리 리스트 만들기
            var categories = new List<Category>()
            {
                new Category() {CategoryId = 1, CategoryName = "좋은 책"},
                new Category() {CategoryId = 2, CategoryName = "좋은 강의"},
                new Category() {CategoryId = 3, CategoryName = "좋은 컴퓨터"}
            };

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }

            //제네릭 클래스 : T에 지정한 형식으로 클래스와 멤버의 성질이 결정
            var text = new Cup<string>();
            text.Content = "String";

            var number = new Cup<int>();
            number.Content = 1_234;

            var person = new Cup<Person>();
            person.Content = new Person { Name = "Hong", Age = 21 };
            Console.WriteLine($"{person.Content.Name} - {person.Content.Age}");
        }

        
    }
}
