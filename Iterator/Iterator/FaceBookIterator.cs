using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.Iterator
{

    public class FaceBookIterator : IIterator
    {

        private LinkedList<string> Users;
        private int position;


        public FaceBookIterator(LinkedList<string> users)
        {
            this.Users = users;
            position = 0;
        }

        public string CurrentItem()
        {
            return Users.ElementAt(position);
        }

        public void First()
        {
            position = 0;
        }

        public bool IsDone()
        {
            return position >= Users.Count;
        }

        public string Next()
        {
            return Users.ElementAt(position++);
        }
    }
}
