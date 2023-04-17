using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerAndIterator
{   
    class Car
    {   
        //[1] 필드
        private string[] names;

        //[2] 생성자
        public Car(int length)
        {
            this.names = new string[length];
        }

        //[3] 인덱서
        public String this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; } // 값을 배열에 담아줌
        }

        //[4] 반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i]; //배열에 담긴 값을 꺼내줌
            }
        }

    }

    class IndexerAndIterator
    {
        static void Main()
        {
            //인덱서 클래스의 인스턴스를 배열처럼 사용가능
            //자동차 카탈로그와 같음
            //Indexer

            Car cars = new Car(3);
            cars[0] = "CLA";
            cars[1] = "CLS";
            cars[2] = "AMG";

            //반복기 iterator
            foreach (var car in cars) // 배열에 담긴 값을 for 돌면서 하나 씩 가져옴 
            {
                Console.WriteLine(car); //CLA, CLS, AMG
            }



        }
    }
}
