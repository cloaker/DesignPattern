using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Decorator.Component;

namespace DesignPattern.Decorator.ConcreteDecorator
{
    public abstract class Topping : IceCream
    {
              protected IceCream IceCream { get; set; }

        protected Topping(IceCream iceCream)
        {
            IceCream = iceCream;
        }

    }
}
