using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Restaurant
    {
        public void MakeFood()
        {   
            Console.WriteLine($"요리 시작");
            DateTime start = DateTime.Now;

            void Egg()
            {
                Thread.Sleep(3000);
                Console.WriteLine("달걀 요리 3초 소요");
            }
            Thread t1 = new Thread(new ThreadStart(Egg));
            
            
            void Soup()
            {
                Thread.Sleep(5000);
                Console.WriteLine("국 5초 소요");
            }
            Thread t2 = new Thread(Soup);


            Thread t3 = new Thread(()=> 
            {
                Thread.Sleep(7000);
                Console.WriteLine("밥 7초 소요");
            });

            t1.Start(); t2.Start(); t3.Start(); //async 비동기 실행
            t1.Join(); t2.Join(); t3.Join();    //모든 스레드가 종료 될때까지 메인 진행 await


            Console.WriteLine($"요리 종료: {(DateTime.Now - start).TotalSeconds}"); //동기 : 15초, 비동기 : 7초

            Console.WriteLine($"식사 시작");
            //Singlepro();
            Multipro();
            Console.WriteLine($"식사 종료: {(DateTime.Now - start).TotalSeconds}"); 
        }
        private void Singlepro()
        {
            for (int i = 0; i < 20_000; i++)
            {
                Console.WriteLine("수다");
            }
        }

        private void Multipro()
        {
            Parallel.For(0, 200_000, (i) => { Console.WriteLine(i); });
        }

        
    }

    class ThreadTest
    {
        
        static void Main()
        {
            //스레드 : 작업자 한명. 
            (new Restaurant()).MakeFood();
        }
    }
}
