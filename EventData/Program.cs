using System;
using System.Threading;

namespace EventData
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、初始化鱼竿
            var fishingRod = new FishingRod();

            //2、声明垂钓者
            var jeff = new FishingMan("Ryan");

            //3.分配鱼竿
            jeff.FishingRod = fishingRod;

            ////4、注册观察者
            //fishingRod.FishingEvent += new FishingEventHandler().HandleEvent;

            //5、循环钓鱼
            while (jeff.FishCount < 5)
            {
                jeff.Fishing();
                Console.WriteLine("-------------------");
                //睡眠5s
                Thread.Sleep(5000);
            }

            Console.Read();

        }
    }
}
