using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Decorator
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Pizza(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException();

            Name = name;
        }
    }
}
