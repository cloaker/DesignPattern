using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class Axe : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("using axe");
        }
    }
}
