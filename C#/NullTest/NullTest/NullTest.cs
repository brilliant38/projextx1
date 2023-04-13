using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullTest
{
    class NullTest
    {
        static void Main(string[] args)
        {
            // null: 아무 것도 없음을 의미하는 리터럴, 개체가 아무 것도 참조하지 않음을 null 참조라고 함
            int i = 0; //값형
            string s = null; //참조형

            string empty = ""; //빈값 empty는 null과는 다름

            //Nullable<T> 형식 : null이 할당 될 수 있는 형식
            //참조형식에는 null이 할당 가능하다.
            Nullable<bool> bln = null;
            //bln.HasValue; //null

            bln = true;
            //bln.HasValue; //not null

            //int x = null; null 할당 불가능
            int? a = null; //type? -> type 뒤에 ?를 붙이면 null 가능 형식이 됨.

            //?? 연산자 (널 병합 연산자 null coalescing Oprator))
            string nullValue = null;
            string message = "";

            //if 구문으로 null 값 비교
            nullValue = null;
            if (nullValue == null)
            {
                message = "[1] null 이면 새로운 값으로 초기화 합니다.";
            }

            //?? 연산자로 null 값 비교
            message = nullValue ?? "[2] null 이면 새로운 값으로 초기화 합니다.";

            message = "Hello";

            message = nullValue ?? "Nothing;";


            int? value = null; // null 가능 형식에 null로 초기화
            int defaultValue = value ?? -1; //value가 null이면 -1 대입


            int? x = null;
            int y = x ?? 100; //x가 null이면 100으로 초기화
            int z = x ?? default(int); //정수형의 기본 값인 0으로 초기화
            //int z = x ?? default; //정수형의 기본 값인 0으로 초기화

            //널 조건부 연산자 (null conditional)

            double? d = null;
            d?.ToString();

            double? e = 1.0;
            d?.ToString(); //1
            d?.ToString("#.00 ");// 1.00

            int? len;
            string message1;

            message1 = null;
            len = message1?.Length; //null

            message = "안녕";
            len = message1?.Length;


            //?. 연산자: 컬렉션이 null이면 null, 아니면 뒤에 오는 속성 값 반환
            //엘비스의 머리 모양과 비슷하다고 하여 elvis 연산자라고도 함

            List<string> list = null;
            int? numberOfList;

            //리스트가 null이면 null 반환
            numberOfList = list?.Count; //null


            list = new List<string>();
            list.Add("안녕하세요.");
            list.Add("반갑습니다.");

            //리스트가 null이 아니므로 count 속성의 값인 2반환
            numberOfList = list?.Count;

            //널 병합 연산자와 널 조건부 연산자 함께 사용하기
            //?? 연산자: 컬렉션이 null이 아니면 해당 값 반환, null이면 뒤에 지정한 값 반환

            //컬렉션 리스트가 null이면 count를 읽을 수 없기에 0으로 초기화
            int num;
            list = null;
            num = list?.Count ?? 0; //null이면 0, 아니면 오른쪽 값

            //컬렉션 리스트가 null이 아니면 count 속성의 값을 사용
            list = new List<string>();
            list.Add("또 만나요.");
            num = list?.Count ?? 0; // null이 아니기 때문에 왼쪽 값 사용
            

        }
    }
}
