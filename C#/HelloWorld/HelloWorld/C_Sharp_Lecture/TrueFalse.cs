using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.C_Sharp_Lecture
{
    class TrueFalse
    {
        static void Main()
        {
            //[?] 논리 자료형: 참 또는 거짓 값 저장
            //bool bln = 1234; 
            //bool bln = "true";
            bool isFalse = false;
            Console.WriteLine(isFalse);

            const string SITE_NAME = "닷넷코리아";
            //SITE_NAME = "VisualAcademy"; 할당 불가

            Char c = 'A'; //struct
            String s = "안녕하세요"; //class
            Boolean b = true;

            $"{c}\n{s}\n{b}";

            //래퍼 형식: int, string
            int number1 = 1234;// 기본형
            Int32 number2 = 1234; // 래퍼형식 struct
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            


        }
    }
}
