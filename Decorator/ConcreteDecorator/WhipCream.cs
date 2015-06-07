using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Decorator.ConcreteDecorator;
using DesignPattern.Decorator.Component;

namespace DesignPattern.Decorator.ConcreteDecorator
{
    public class WhipCream : Topping
    {

        public WhipCream(IceCream iceCream) : base(iceCream)
        {

        }
        public override double Cost()
        {
            double price = 1.00;

            return price + IceCream.Cost();
        }
    }
}
