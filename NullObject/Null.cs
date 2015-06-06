using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy;

namespace DesignPattern.NullObject
{
    public class Null : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Null Object Encountered");
        }
    }
}
