using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Facade.Concrete;

namespace DesignPattern.Facade.Facade
{
    public class PizzaFacade
    {
        private Dough dough;
        private Cheese cheese;
        private Sauce sauce;
        private PizzaTopping topping;
        private Oven oven = new Oven();

        public PizzaFacade(Dough dough, Cheese cheese, Sauce sauce, PizzaTopping topping)
        {
            this.dough = dough;
            this.cheese = cheese;
            this.sauce = sauce;
            this.topping= topping;
            this.oven = oven;
        
            
        }

        public void MakePizza()
        {
            dough.AddCheese(cheese);
            dough.AddSauce(sauce);           
            dough.AddTopping(topping);          
            oven.SetTemperature(450);
            oven.SetTimer(15);
            oven.Cook(dough);
        }


    }
}
