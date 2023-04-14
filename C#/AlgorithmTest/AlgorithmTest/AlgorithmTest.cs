using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    class AlgorithmTest
    {
        static void Main(string[] args)
        {
            //Input
            int[] data = { 3, 2, 1, 5, 4 };

            //data[5] { 3,2,1,5,4}
            //1,2,3,4,5로 정렬

            //Array.Sort(data); Sort 메서드 사용

            data.OrderBy(d => d);
            data.OrderByDescending(x => x); //Descending 메서드 사용

            //Process
            //선택정렬 알고리즘
            for (int i = 0; i<data.Length -1; i++) //0부터 마지막 이전 값까지만 비교 
            {
                for(int j = i+1; j<data.Length; j++)
                {
                    if(data[i] < data[j]) //i가 j보다 큰 경우
                    {
                        int temp = data[i]; //i번째를 temp에 입력
                        data[i] = data[j]; //다음 위치 숫자를 i로 이동
                        data[j] = temp;     //temp의 숫자를 j에 입력
                    }
                }
            }
            
            //output
            //data





        }
    }
}
