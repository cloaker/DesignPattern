using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Iterator.Iterator;

namespace DesignPattern.Iterator.Aggregate
{
    public class Facebook : ISocialNetworking
    {
        private LinkedList<string> Users;

        public Facebook()
        {
            Users = new LinkedList<string>();
            Users.AddLast("Alison");
            Users.AddLast("Jax");
            Users.AddLast("Ivy");
            Users.AddLast("Nikki");
            Users.AddLast("Lynn");
            Users.AddLast("Ginger");
            Users.AddLast("Vince");

        }

        public IIterator CreateIterator()
        {
            return new FaceBookIterator(Users);
        }
    }
}
