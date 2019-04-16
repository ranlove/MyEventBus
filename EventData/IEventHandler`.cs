using System;
using System.Collections.Generic;
using System.Text;

namespace EventData
{
    public  interface IEventHandler<TEventData>: IEventHandler where TEventData:IEventData
    {
        /// <summary>
        /// 事件处理器实现该方法来处理事件
        /// </summary>
        /// <param name="eventData"></param>
        void HandleEvent(TEventData eventData);
    }
}
