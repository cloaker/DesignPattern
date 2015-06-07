using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Subscriber
{
    public class RegularSubscriber : ISubscriber
    {
        public void notifySubscriber(string channelName)
        {
            Console.WriteLine(channelName + " Regular Subsciber New Content Available");
        }
    }
}
