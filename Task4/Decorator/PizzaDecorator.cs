using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza Pizza { get; set; }

        public PizzaDecorator(Pizza pizza) : base(pizza.Name)
        {
            if (pizza is null)
                throw new ArgumentException();

            Pizza = pizza;
            Price = pizza.Price;
        }
    }
}
