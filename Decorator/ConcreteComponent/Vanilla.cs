using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Decorator.Component;

namespace DesignPattern.Decorator.ConcreteComponent
{
    public class Vanilla : IceCream
    {
        public override double Cost()
        {
            double price = 1.5;

            return price;
        }
    }
}
