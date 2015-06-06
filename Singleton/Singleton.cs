using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        private static Singleton getInstance;

        private Singleton()
        { }

        public static Singleton GetInstance()
        {
            if (getInstance == null)
            {
                getInstance = new Singleton();
                Console.WriteLine("instance created");
            }
            else
            {
                Console.WriteLine("existing instance");
            }

            return getInstance;
        }
    }
}
