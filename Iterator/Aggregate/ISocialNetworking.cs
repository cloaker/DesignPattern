using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Iterator.Iterator;

namespace DesignPattern.Iterator.Aggregate
{
    public interface ISocialNetworking
    {
        IIterator CreateIterator();

    }
}
