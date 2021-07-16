using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator.ConcreteDecorators
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza)
        {
            Name += " с сыром";
            Price += 2;
        }
    }
}
