using System;
using System.Collections.Generic;
using System.Text;

namespace EventData
{
    /// <summary>
    /// 垂钓者（观察者）
    /// </summary>
    public class FishingMan
    {
        public FishingMan(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int FishCount { get; set; }

        /// <summary>
        /// 垂钓者自然要有鱼竿啊
        /// </summary>
        public FishingRod FishingRod { get; set; }

        public void Fishing()
        {
            this.FishingRod.ThrowHook(this);
        }

        //public void HandleEvent(IEventData eventData)
        //{
        //    if (eventData is FishingEventData d)
        //    {
        //        Update(d);
        //    }           
        //}

        //public void Update(FishingEventData eventData)
        //{
        //    FishCount++;
        //    Console.WriteLine("{0}：钓到一条[{2}]，已经钓到{1}条鱼了！", Name, FishCount, eventData.FishType);
        //}
    }
}
