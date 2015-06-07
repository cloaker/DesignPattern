using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Observer.Subscriber;

namespace DesignPattern.Observer.Publisher
{
    public class TwitterChannel : IPublisher
    { 
        private IList<ISubscriber> mySubsciberList = new List<ISubscriber>();
        private string channelName = "Twitter Channel";

        public void notifySubscribers()
        {
            foreach (var user in mySubsciberList)
            {
                user.notifySubscriber(channelName);
            }
        }
    
        public void registerSubscriber(ISubscriber subscriber)
        {
            mySubsciberList.Add(subscriber); 
        }
   
        public void unregisterSubscriber(ISubscriber subscriber)
        {
            mySubsciberList.Remove(subscriber);
        }
    }
}
