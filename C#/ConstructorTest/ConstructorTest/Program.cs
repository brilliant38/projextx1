using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    //기본생성자 ctor tab tab
    //리턴 없고 매개변수 없고
    //생성자 메서드

    private string name;
    public Car() // : this("기본자동차") //2 생성자 포워딩
    {
        //Console.WriteLine("자동차 객체를 생성합니다. 조립, 시동걸어");
        name = "기본 자동차";
    }
    
    public Car(string name)
    {
        this.name = name; //this.필드 = 매개변수
    }

    public void Go() => Console.WriteLine($"{name}가 달린다."); //4

}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(); //1
        // (new Car()).Go(); //이런 생성 스타일도 있다.
        car.Go(); //3

        Car my = new Car("좋은 자동차");
        my.Go();
    }
}