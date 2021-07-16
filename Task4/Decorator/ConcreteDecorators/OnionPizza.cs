using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator.ConcreteDecorators
{
    class OnionPizza : PizzaDecorator
    {
        public OnionPizza(Pizza pizza) : base(pizza)
        {
            Name += " с луком";
            Price += 1;
        }
    }
}
