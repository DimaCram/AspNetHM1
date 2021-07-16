using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator.ConcreteDecorators
{
    public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base(pizza)
        {
            Name += " с томатами";
            Price += 3;
        }
    }
}
