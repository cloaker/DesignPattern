using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Subscriber
{
    public interface ISubscriber
    {
        void notifySubscriber(string channelName);
    }
}
