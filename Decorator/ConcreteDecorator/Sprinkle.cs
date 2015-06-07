using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Decorator.Component;

namespace DesignPattern.Decorator.ConcreteDecorator
{
    public class Sprinkle : Topping
    {

        public Sprinkle(IceCream iceCream) : base(iceCream)
        {

        }
        public override double Cost()
        {
            double price = 0.50;

            return price + IceCream.Cost();
        }
    }
}
