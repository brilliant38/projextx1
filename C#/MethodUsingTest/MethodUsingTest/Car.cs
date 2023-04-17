using System;

namespace MethodUsingTest
{   
    class Car
    {
        //public void Map(string title) => Console.WriteLine($"[2] {title}"); //참조
        //public void Map(ref string title) //참조 변경
        //public void Map(out string title) //참조 반환
        public void Map(params string[] title)//배열형 매개변수 전달.
        {
            //title = "참조변경"; //최초 생성된 title을 보고있음.
            //title = "참조반환"; //생성자에서 필드 최초 초기화
            //Console.WriteLine($"[2] {title}"); //
            foreach (var t in title)
            {
                Console.WriteLine(t);
            }
        }
    }
}
