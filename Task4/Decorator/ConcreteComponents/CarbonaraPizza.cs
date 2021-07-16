using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator.ConcreteComponents
{
    public class СarbonaraPizza : Pizza
    {
        public СarbonaraPizza() : base("Карбонара пицца")
        {
            Price = 28;
        }
    }
}
