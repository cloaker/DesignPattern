using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Observer.Subscriber;

namespace DesignPattern.Observer.Publisher
{
    public interface IPublisher
    {
        void registerSubscriber(ISubscriber subscriber);
        void unregisterSubscriber(ISubscriber subscriber);
        void notifySubscribers();

    }
}
