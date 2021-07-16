using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator.ConcreteComponents
{
    public class MexicanPizza : Pizza
    {
        public MexicanPizza() : base("Мексиканская пицца")
        {
            Price = 26;
        }
    }
}
