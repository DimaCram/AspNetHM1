using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator.ConcreteDecorators
{
    class ChilliPizza : PizzaDecorator
    {
        public ChilliPizza(Pizza pizza) : base(pizza)
        {
            Name += " с перцем чили";
            Price += 4;
        }
    }
}
