using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Say
{
    private string message = "반갑습니다."; //필드
    public void Hi()
    {
        Console.WriteLine(this.message);
    }
}

public class Car
{
    private string color = "Red";

    public string GetColor() => color;
}

public class Person
{
    private string name = "이광재";
    private const int m_age = 21; //필드
    private readonly string _NickName = "RedPlus";
    private string[] _websites = { "닷넷코리아", "비주얼아카데미" };

    public void ShowProfile() => Console.WriteLine($"{name} - {string.Join(",",_websites)}");

    public Person()
    {
        _NickName = "Redplus"; //readonly는 생성자에서 초기화 가능함.
    }
}

public class Program
{
    private static string message = "안녕하세요.."; //필드

    public static void Hi() => Console.WriteLine(message);

    public static void Main(string[] args)
    {
        //클래스 안에서 선언된 변수를 필드라고 함.
        //Field는 대부분 Private 한정자가 붙음
        //액세스 한정자. 기본값이 private
        //public 접근 제한 없음
        //private 해당 형식에서만 접근 가능
        //protected 해당 형식 또는 상속받은 자식 형식
        //internal 해당 형식이 속해있는 어셈블리(프로젝트)에서 접근가능
        //protected intenal 해당 형식을 상속받은 자식 또는 해당 어셈블리에서 접근 가능

        //readonly 대문자로 시작 가능
        //생성자를 통해서 초기화 가능
        //선언과 동시에 초기화

        //컴파일 타임 상수 -> 컴파일 시점에 데이터가 저장됨 static
        //런타임 상수 -> 선언과 동시 초기화 or 생성자에 의한 초기화, static으로 선언 가능 하나 대부분은 인스턴스로 선언
        // 캡슐화 개체의 데이터는 해당 개체 에서만 접근 가능하도록 설정
        //필드는 private 잊지마라

        //클래스의 부품 역할을 하는 클래스의 내부 상태 값을 저장해 놓는 그릇

        int number = 1_234; // 변수, 지역 변수
        Console.WriteLine(number);
        Console.WriteLine(message);
        Hi();
        Say say = new Say();
        say.Hi();

        Car car = new Car();
        Console.WriteLine(car.GetColor());  //private이면 보호수준때문에 color 접근 불가 하지만 get method로 가져옴

        Person my = new Person();
        my.ShowProfile();


    }
}