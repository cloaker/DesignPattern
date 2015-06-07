using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Subscriber
{
    public class Moderator : ISubscriber
    {
        public void notifySubscriber(string channelName)
        {
            Console.WriteLine(channelName + " Moderator New Content to Review");
        }
    }
}
