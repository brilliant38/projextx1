using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dinner.Common
{
    public class Cooking
    {
        //동기 방식의 밥 만들기 메서드
        public Rice MakeRice()
        {
            Console.WriteLine("밥 생성중...");
            Thread.Sleep(1001);
            return new Rice();
        }

        public async Task<Rice> MakeRiceAsync()
        {
            Console.WriteLine("밥 생성중...");
            await Task.Delay(1001);
            return new Rice();
        }

        public Soup MakeSoup()
        {
            Console.WriteLine("국 생성중...");
            Thread.Sleep(1001);
            return new Soup();
        }

        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("국 생성중...");
            await Task.Run(() => Task.Delay(1001));
            return new Soup();
        }
        public Egg MakeEgg()
        {
            Console.WriteLine("달걀 생성중...");
            Thread.Sleep(1001);
            return new Egg();
        }
        public async Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("달걀 생성중...");
            await Task.Delay(TimeSpan.FromMilliseconds(3001));
            return await Task.FromResult<Egg>(new Egg());
        }
    }
    public class Rice
    {
        //pass
    }
    public class Soup
    {
        //pass
    }
    public class Egg
    {
        //pass
    }

}
