using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Iterator.Iterator;

namespace DesignPattern.Iterator.Aggregate
{
    public class Twitter : ISocialNetworking
    {
        private string[] Users;

        public Twitter()
        {
            Users = new[] { "Vince", "Denise", "Alexis", "Viansa", "Tom", "Madison" };
        }

        public IIterator CreateIterator()
        {
            return new TwitterIterator(Users);
        }
    }
}
