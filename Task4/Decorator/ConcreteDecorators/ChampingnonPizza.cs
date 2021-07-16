using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator.ConcreteDecorators
{
    class ChampignonPizza : PizzaDecorator
    {
        public ChampignonPizza(Pizza pizza) : base(pizza)
        {
            Name += " с шампиньонами";
            Price += 5;
        }
    }
}
