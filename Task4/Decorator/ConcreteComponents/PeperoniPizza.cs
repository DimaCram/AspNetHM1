using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator.ConcreteComponents
{
    public class PeperoniPizza : Pizza
    {
        public PeperoniPizza() : base("Пицца пеперони")
        {
            Price = 20;
        }
    }
}
