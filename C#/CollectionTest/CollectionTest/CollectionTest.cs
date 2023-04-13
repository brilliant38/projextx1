using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CollectionTest
{
    class CollectionTest
    {
        static void Main(string[] args)
        {
            //컬렉션 : 배열, 리스트, 사전을 사용하여 관련 개체의 그룹을 만들고 관리하는데 사용
            //1. 변수

            int number = 1_234;
            Console.WriteLine(number);

            //2.배열
            string[] colors = { "red", "green", "blue" };
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);
            
            
            //Console.WriteLine(colors[100]); //예외 발생
            Console.WriteLine("--------");
            Array.Sort(colors);
            Console.WriteLine(colors[0]);
            foreach(var color in colors)
            {
                Console.WriteLine(color); //a,b,c 순서로 정렬된 배열값이 출력
            }

            Array.Reverse(colors);
            foreach (var color in colors)
            {
                Console.WriteLine(color); //c,b,a 순서로 정렬된 배열값이 출력
            }

            //3. Collection

            //using System.Collections;
            //Stack

            Stack<int> stack = new Stack<int>(); //LIFO
            stack.Push(100); //모든 데이터를 담을 수 있는 메서드
            stack.Push(200); //모든 데이터를 담을 수 있는 메서드
            Console.WriteLine(stack.Pop()  );  //나중에 들어온 것부터 데이터를 리턴
            Console.WriteLine(stack.Pop()  );  //나중에 들어온 것부터 데이터를 리턴


            //Queue FIFO
            Console.WriteLine("------");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(100);
            queue.Enqueue(200);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            queue.Enqueue(200);
            queue.Enqueue(100);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            /*
             * 변수 배열 구조체 클래스
             * 스택 :LIFO
             * 큐:FIFO
             * 리스트 : LIFO + FIFO
             * 트리 :계층형 데이터 구조
             * 그래프: 망형 데이터
             */

            //ArrayList
            Console.WriteLine("------");
            ArrayList lists = new ArrayList();
            lists.Add(100);
            lists.Add(100); //추가
            lists.RemoveAt(1); //삭제
            lists.Add(200);
            lists.Insert(0, 50);
            

            foreach(var list in lists)
            {
                Console.WriteLine(list);
            }

            //HashTable
            Console.WriteLine("------");

            Hashtable hashtable = new Hashtable();
            hashtable[0] = "DotNetKorea";
            hashtable["NickName"] = "RedPlus";

            Console.WriteLine(hashtable[0]);


        }
    }
}
